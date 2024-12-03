using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    public class Factorial
    {
        public long fact(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            //si n no es igual a 0 o 1 el algoritmo hace iteraciones
            //Cuando el valor de num sea 1 el algortimo para
            return num * fact(num - 1);
        }
    }
}
