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
        // double G = 1;
        public int QuantidadeCorpos;
        public int QuantidadeIteracoes;
        public double Tempo;



        #region Métodos de formulas para cálculo
        public double CalculaDistancia(CorpoCelestial body1, CorpoCelestial body2)
        {
            return Math.Sqrt(Math.Pow((body1.PosX - body2.PosX), 2) + Math.Pow((body1.PosY - body2.PosY), 2));
        }

        public double CalculaForca(CorpoCelestial body1, CorpoCelestial body2)
        {
            double distancia = CalculaDistancia(body1, body2);
            double force = G * ((body1.Massa * body2.Massa) / Math.Pow(distancia, 2));

            return force;
        }


        public double SomaForcaX(List<CorpoCelestial> lista, CorpoCelestial body1)
        {
            double Fx = 0;
            double force = 0;


            for (var j = 0; j < lista.Count; ++j)
            { if (lista[j] != body1)
                {
                    double distancia = CalculaDistancia(body1, lista[j]);
                    double forca = CalculaForca(body1, lista[j]);
                    double rx = body1.PosX - lista[j].PosX;
                    Fx = forca * (rx / distancia);

                    Fx = force + Fx;
                }
            }
            return Fx;

        }

        public double SomaForcaY(List<CorpoCelestial> lista, CorpoCelestial body1)
        {
            double Fy = 0;
            double force = 0;

            for (var j = 0; j < lista.Count; ++j)
            {
                if (lista[j] != body1)
                {
                    double distancia = CalculaDistancia(body1, lista[j]);
                    double forca = CalculaForca(body1, lista[j]);
                    double ry = body1.PosY - lista[j].PosY;
                    Fy = forca * (ry / distancia);

                    Fy = force + Fy;
                }
            }
            return Fy;

        }

        public void AplicaForca(CorpoCelestial body, double Fx, double Fy)
        {
            double Ax = Fx / body.Massa;
            double Ay = Fy / body.Massa;

            double Vx = body.VelX + (Ax * Tempo);
            double Vy = body.VelY + (Ay * Tempo);

            double Sx = body.PosX + (body.VelX * Tempo) + ((Ax * Math.Pow(Tempo, 2)) / 2);
            double Sy = body.PosY + (body.VelY * Tempo) + ((Ay * Math.Pow(Tempo, 2)) / 2);

            body.PosX = Sx;
            body.PosY = Sy;
            body.VelX = Vx;
            body.VelY = Vy;
        }


        public void AplicaForcaGravitacional(List<CorpoCelestial> lista, CorpoCelestial body1)
        {

            double Fx = SomaForcaX(lista, body1);
            double Fy = SomaForcaY(lista, body1);

            AplicaForca(body1, Fx, Fy);
        }

        public void VerificaColisao(List<CorpoCelestial> lista)
        {
            double distancia;
            bool colisao = false;




            for (int i = 0; i < lista.Count; i++)
            {

                for (int j = i + 1; j < lista.Count; j++)
                {

                    distancia = CalculaDistancia(lista[i], lista[j]);

                    if (distancia < lista[i].Raio + lista[j].Raio)
                    {
                        double PI = 3.1415926535897931;
                        double SomaVolume = ((4 / 3) * PI * Math.Pow(lista[i].Raio, 3)) + ((4 / 3) * PI * Math.Pow(lista[j].Raio, 3));
                        var novo = new CorpoCelestial()
                        {
                            Massa = lista[i].Massa + lista[j].Massa
                            ,
                            Nome = string.Concat(lista[j].Nome, lista[i].Nome)
                            ,
                            PosX = ((lista[i].PosX * lista[i].Massa) + (lista[j].PosX * lista[j].Massa)) / (lista[i].Massa + lista[j].Massa)
                            ,
                            PosY = ((lista[i].PosY * lista[i].Massa) + (lista[j].PosY * lista[j].Massa)) / (lista[i].Massa + lista[j].Massa)
                            ,
                            Raio = Math.Cbrt((3 * SomaVolume) / (4 * PI))
                            ,
                            VelX = ((lista[i].Massa * lista[i].VelX) + (lista[j].Massa * lista[j].VelX)) / (lista[i].Massa + lista[j].Massa)
                            ,
                            VelY = ((lista[i].Massa * lista[i].VelY) + (lista[j].Massa * lista[j].VelY)) / (lista[i].Massa + lista[j].Massa)
                        };

                        colisao = true;
                        CorpoCelestial removei = lista.Where(a => a.Nome == lista[i].Nome).First();
                        CorpoCelestial removej = lista.Where(a => a.Nome == lista[j].Nome).First();
                        lista.Add(novo);
                        lista.RemoveAll((x) => x.Nome == removei.Nome);
                        lista.RemoveAll((x) => x.Nome == removej.Nome);

                    }
                    else
                    {
                        break;

                    }
                    break;
                }

            }
        }
    

        public void VerificaColisao2(List<CorpoCelestial> lista)
        {
            double distancia;
            foreach (CorpoCelestial i in lista)
            {
                foreach (CorpoCelestial j in lista)
                {
                    if (i != j)
                    {
                        distancia = CalculaDistancia(i, j);

                        if (distancia < i.Raio +j.Raio)
                        {
                            double PI = 3.1415926535897931;
                            double SomaVolume = ((4 / 3) * PI * Math.Pow(i.Raio, 3)) + ((4 / 3) * PI * Math.Pow(j.Raio, 3));
                            var novo = new CorpoCelestial()
                            {
                                Massa = i.Massa + j.Massa
                                ,
                                Nome = string.Concat(j.Nome, i.Nome)
                                ,
                                PosX = ((i.PosX * i.Massa) + (j.PosX * j.Massa)) / (i.Massa + j.Massa)
                                ,
                                PosY = ((i.PosY * i.Massa) + (j.PosY * j.Massa)) / (i.Massa + j.Massa)
                                ,
                                Raio = Math.Cbrt((3 * SomaVolume) / (4 * PI))
                                ,
                                VelX = ((i.Massa * i.VelX) + (j.Massa * j.VelX)) / (i.Massa + j.Massa)
                                ,
                                VelY = ((i.Massa * i.VelY) + (j.Massa * j.VelY)) / (i.Massa + j.Massa)
                            };

                            lista.Remove(i);
                            lista.Remove(j);
                            lista.Add(novo);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        #endregion





    }
}
