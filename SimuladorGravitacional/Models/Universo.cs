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
       
             

        #region Métodos de formulas para cálculo
        public double CalculaDistancia(CorpoCelestial body1, CorpoCelestial body2)
        {
            return Math.Sqrt(Math.Pow((body1.PosX- body2.PosX), 2) + Math.Pow((body1.PosY - body2.PosY), 2));
        }

        public double CalculaForca(CorpoCelestial body1, CorpoCelestial body2)
        {
            double distancia = CalculaDistancia(body1, body2);
            double force = G * ((body1.Massa * body2.Massa) / Math.Pow(distancia, 2));

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

       



    }
}
