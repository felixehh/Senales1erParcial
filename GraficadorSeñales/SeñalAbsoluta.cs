using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class SeñalAbsoluta
    {
        public List<Muestra> Muestras
        { get; set; }

        public SeñalAbsoluta()
        {
            Muestras =
                new List<Muestra>();
        }

        public double evaluar(double tiempo)
        {
            double resultado;

            resultado = Math.Abs(tiempo);

            return resultado;
        }
    }
}
