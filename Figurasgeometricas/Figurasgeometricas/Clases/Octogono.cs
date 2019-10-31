using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurasgeometricas.Clases
{
    class Octogono : Figura_geometrica
    {
        public double Lado { get; set; }

        public Octogono()
        {
        }


        public override void CalcularArea()
        {
            Area = Math.Round(2 * Math.Pow(this.Lado, 2) / Math.Tan(Math.PI / 8), 2);
        }
    }
}
