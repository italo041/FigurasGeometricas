using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurasgeometricas.Clases
{
    class Trapecio : Figura_geometrica
    {
        public double Bmayor { get; set; }
        public double Bmenor { get; set; }
        public double Altura { get; set; }

        public Trapecio()
        {
        }

        public override void CalcularArea()
        {
            Area = this.Altura * (this.Bmayor + this.Bmenor) / 2;
        }
    }
}
