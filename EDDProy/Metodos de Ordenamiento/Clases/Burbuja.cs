using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Ordenamiento.Clases
{
    public class Burbuja
    {
        public static void OrdenarBurbuja(ListaSimple lista)
        {
            if (lista.estaVacio())
                return;
            bool intercambio;
            Nodo numPasada = lista.Cabeza;
            while (numPasada != null && numPasada.Sig != null)
            {
                intercambio = false;
                Nodo actual = lista.Cabeza;
                while (actual.Sig != null)
                {
                    if (int.Parse(actual.Dato) > int.Parse(actual.Sig.Dato))
                    {
                        string temp = actual.Dato;
                        actual.Dato = actual.Sig.Dato;
                        actual.Sig.Dato = temp;

                        intercambio = true;
                    }
                    actual = actual.Sig;
                }
                if (!intercambio)
                    break;

                numPasada = numPasada.Sig;
            }
        }
    }
}
