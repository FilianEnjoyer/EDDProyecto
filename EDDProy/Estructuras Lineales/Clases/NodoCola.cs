using EDDemo.Estructuras_No_Lineales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class NodoCola<T>
    {
        public T Dato;
        public NodoCola<T> Sig;

        public NodoCola(T dato)
        {
            Dato = dato;
            Sig = null;
        }
    }
}
