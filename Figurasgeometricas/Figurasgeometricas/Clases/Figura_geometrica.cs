using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurasgeometricas
{
    abstract class Figura_geometrica
    {
        private double area;

        public double Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }

        public abstract void CalcularArea();

    }

}
