using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    internal class Potencia
    {
        public int Pot(int bas, int pot)
        {
            if (pot == 0)//O(1)
            //cualquier numero a la potencia 0 es 1
            {
                return 1;//O(1)
            }
            else//O(1)
            //ejecuto la formula a^b=a*a^b-1
            {
                return bas * Pot(bas, pot - 1);//O(n)
            }
        }
    }
}
