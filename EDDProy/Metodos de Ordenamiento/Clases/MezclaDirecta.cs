using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Ordenamiento.Clases
{
    public class MezclaDirecta
    {
        public static ListaSimple MezclaDire(ListaSimple lista)
        {
            if (lista.Cabeza == null || lista.Cabeza.Sig == null)
            {
                return lista;
            }
            ListaSimple izq = new ListaSimple();
            ListaSimple der = new ListaSimple();
            Dividir(lista, izq, der);
            izq = MezclaDire(izq);
            der = MezclaDire(der);
            return Mezclar(izq, der);
        }
        public static void Dividir(ListaSimple lista, ListaSimple izq, ListaSimple der)
        {
            Nodo actual = lista.Cabeza;
            Nodo lento = actual;
            Nodo rapido = actual?.Sig;
            while (rapido != null && rapido.Sig != null)
            {
                lento = lento.Sig;
                rapido = rapido.Sig.Sig;
            }
            Nodo mitad = lento.Sig;
            lento.Sig = null;
            Nodo temp = lista.Cabeza;
            while (temp != null)
            {
                izq.InsertarFinal(temp.Dato);
                temp = temp.Sig;
            }
            temp = mitad;
            while (temp != null)
            {
                der.InsertarFinal(temp.Dato);
                temp = temp.Sig;
            }
        }
        public static ListaSimple Mezclar(ListaSimple izq, ListaSimple der)
        {
            ListaSimple listaOrdenada = new ListaSimple();
            Nodo nodoIzq = izq.Cabeza;
            Nodo nodoDer = der.Cabeza;
            while (nodoIzq != null && nodoDer != null)
            {
                if (int.Parse(nodoIzq.Dato) <= int.Parse(nodoDer.Dato))
                {
                    listaOrdenada.InsertarFinal(nodoIzq.Dato);
                    nodoIzq = nodoIzq.Sig;
                }
                else
                {
                    listaOrdenada.InsertarFinal(nodoDer.Dato);
                    nodoDer = nodoDer.Sig;
                }
            }
            while (nodoIzq != null)
            {
                listaOrdenada.InsertarFinal(nodoIzq.Dato);
                nodoIzq = nodoIzq.Sig;
            }
            while (nodoDer != null)
            {
                listaOrdenada.InsertarFinal(nodoDer.Dato);
                nodoDer = nodoDer.Sig;
            }
            return listaOrdenada;
        }
    }
}
