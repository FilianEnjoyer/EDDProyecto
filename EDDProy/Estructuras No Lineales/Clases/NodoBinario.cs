using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace EDDemo.Estructuras_No_Lineales
{
    public class NodoBinario
    {
        public int Dato;
        public NodoBinario Izq;
        public NodoBinario Der;
        public NodoBinario (int dato)
        {
            this.Dato = dato;
            this.Izq = null;
            this.Der = null;
        }
    }
}
