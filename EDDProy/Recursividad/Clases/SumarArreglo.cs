using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    public class SumarArreglos
    {
        public int Sumar(int[] arreglo, int posicion = 0)
        {
            if (posicion == arreglo.Length)
                return 0;

            return arreglo[posicion] + Sumar(arreglo, posicion + 1);
        }
        public void Recorrer(int[] arreglo, int posicion = 0)
        {
            if (posicion == arreglo.Length)
                return;

            Console.WriteLine(arreglo[posicion]);
            Recorrer(arreglo, posicion + 1);
        }
    }
}
