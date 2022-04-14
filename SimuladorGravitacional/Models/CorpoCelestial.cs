using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorGravitacional.Models
{
    internal class CorpoCelestial
    {

        public string Nome { get; set; }
        public double Massa { get; set; }
        public double Raio { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }
        public double VelX { get; set; }
        public double VelY { get; set; }

        public string formatOutputFile()
        {
            return String.Format("{0};{1};{2};{3};{4};{5};{6}", Nome, Massa, Raio, PosX, PosY, VelX, VelY);
        }



    }
}
