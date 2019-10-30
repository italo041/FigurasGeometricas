using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurasgeometricas.Clases
{
    class Romboide : Figura_geometrica
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public Romboide()
        {
        }

        public override void CalcularArea()
        {
            Area = this.Base * this.Altura;
        }
    }
}
