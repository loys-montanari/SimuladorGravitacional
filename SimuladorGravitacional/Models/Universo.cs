using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorGravitacional.Models
{
    internal class Universo
    {
        double G = 6.674184 * Math.Pow(10, -11);

        public int QuantidadeCorpos;
        public int QuantidadeIteracoes;
        public int Tempo;
       
        
        public List<CorpoCelestial> LerCorposCelestiais()
        {
            List<CorpoCelestial> CorposCelestiais = new List<CorpoCelestial>();
            string file = "Files/Input.txt";

            // Verifica se o arquivo não existe, se não existir retorna uma quantidade vazia de corpos
            if (!File.Exists(file))
            {
                Console.WriteLine(String.Format("Arquivo {0} não existe", file));
                return CorposCelestiais;
            }

            string[] lines = File.ReadAllLines(file);
            int counter = 0;
            foreach (var line in lines)
            {
                // Se for a primeira linha, pega as informações iniciais de execução
                if (counter == 0)
                {
                    string[] data = line.Split(";");

                    QuantidadeCorpos = int.Parse(data[0]);
                    QuantidadeIteracoes = int.Parse(data[1]);
                    Tempo = int.Parse(data[1]);
                }

                //if (counter > 0 && counter <= QuantidadeCorpos)
                //{
                //    CorpoCelestial novoCorporCelestial = new CorpoCelestial(line);
                //    CorposCelestiais.Add(novoCorporCelestial);
                //}

                counter++;
            }

            return CorposCelestiais;
        }

        public void SalvaCorpos(List<CorpoCelestial> CorposCelestiais, int iteration)
        {
            string file = "outputBodies.txt";

            FileStream myFile = new FileStream(file, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(myFile, Encoding.UTF8);

            if (iteration == 0)
            {
                string firstLine = String.Format("{0};{1}", CorposCelestiais.Count, iteration);
                sw.WriteLine(firstLine);
            }


            sw.WriteLine(String.Format("************ Interacao {0} ************", (iteration + 1)));
            for (int i = 0; i < CorposCelestiais.Count; i++)
            {
                sw.WriteLine(CorposCelestiais[i].FormataArquivoSaida());
            }

            sw.Close();
            myFile.Close();

        }

        #region Métodos de formulas para cálculo
        public double CalculaDistancia(CorpoCelestial body1, CorpoCelestial body2)
        {
            return Math.Sqrt(Math.Pow((body1.PosX- body2.PosX), 2) + Math.Pow((body1.PosY - body2.PosY), 2));
        }

        public double CalculaForca(CorpoCelestial body1, CorpoCelestial body2)
        {
            double distanceEuclidienne = CalculaDistancia(body1, body2);
            double force = G * ((body1.Massa * body2.Massa) / Math.Pow(distanceEuclidienne, 2));

            return force;
        }

        public void AplicaForca(CorpoCelestial body, double Fx, double Fy)
        {
            double Ax = Fx / body.Massa;
            double Ay = Fy / body.Massa;

            double Vx = body.VelX + (Ax * Tempo);
            double Vy = body.VelY + (Ay * Tempo);

            double Sx = body.PosX + body.VelX + ((Ax * Math.Pow(Tempo, 2)) / 2);
            double Sy = body.PosY+ body.VelY + ((Ay * Math.Pow(Tempo, 2)) / 2);

            body.PosX = Sx;
            body.PosY = Sy;
            body.VelX = Vx;
            body.VelY = Vy;
        }

        public void AplicaForcaGravitacional(CorpoCelestial body1, CorpoCelestial body2)
        {
            double F = CalculaForca(body1, body2);

            double r = CalculaDistancia(body1, body2);
            double rx = Math.Abs(body1.PosX - body2.PosX);
            double ry = Math.Abs(body1.PosY - body2.PosY);

            double Fx = F * Math.Cos(r / rx);
            double Fy = F * Math.Sin(r / ry);

            AplicaForca(body1, Fx, Fy);
            AplicaForca(body2, Fx * (-1), Fy * (-1));
        }

        #endregion

        public void run()
        {
            List<CorpoCelestial> CorposCelestiais = LerCorposCelestiais();

            if (CorposCelestiais.Count > 1)
            {
                for (int iteracao = 0; iteracao < QuantidadeIteracoes; iteracao++)
                {
                    for (var i = 0; i < CorposCelestiais.Count; ++i)
                    {
                        for (var j = i + 1; j < CorposCelestiais.Count; ++j)
                        {
                            AplicaForcaGravitacional(CorposCelestiais[i], CorposCelestiais[j]);
                        }
                    }

                    SalvaCorpos(CorposCelestiais, iteracao);
                }
            }
        }



    }
}
