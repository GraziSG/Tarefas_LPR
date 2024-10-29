using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO
{
    internal class Retangulo
    {
        public double altura;
        public double largura;

        public double calcArea ()
        {
            return altura * largura;
        }

        public double calPerimetro()
        {
            return (2 * altura) + (2 * largura);
        }
    }
}
