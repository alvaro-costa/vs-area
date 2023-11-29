using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseObjeto
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public Triangulo(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p- A) * (p-B) * (p-C));
        }

        public override string ToString()
        {
            return $"Class: Triangulo\nLados do Triangulo: A={A}, B={B} e C={C}";
        }
    }
}
