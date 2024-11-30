using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class NodoDoble
    {
        public string Dato;
        public NodoDoble Sig;
        public NodoDoble Ant;
        public NodoDoble(string dato)
        {
            Dato = dato;
            Sig = null;
            Ant = null;
        }
    }
}
