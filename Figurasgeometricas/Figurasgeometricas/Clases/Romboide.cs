using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurasgeometricas.Clases
{
    class Romboide : Figura_geometrica
    {
        public double base_;
        public double altura;

        public double calcularArea(double base_, double altura)
        {
            Area = base_ * altura;
            return Area;
        }
    }
}
