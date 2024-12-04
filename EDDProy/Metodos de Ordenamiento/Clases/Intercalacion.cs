using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Ordenamiento.Clases
{
    public class Intercalacion
    {
        public ListaSimple FuncionIntercalacion(ListaSimple lista1, ListaSimple lista2)
        {
            ListaSimple lista = new ListaSimple();
            Nodo nodo1 = lista1.Cabeza;
            Nodo nodo2 = lista2.Cabeza;

            while (nodo1 != null && nodo2 != null)
            {
                if (int.Parse(nodo1.Dato) < int.Parse(nodo2.Dato))
                {
                    lista.InsertarFinal(nodo1.Dato);
                    nodo1 = nodo1.Sig;
                }
                else
                {
                    lista.InsertarFinal(nodo2.Dato);
                    nodo2 = nodo2.Sig;
                }
            }
            while (nodo1 != null)
            {
                lista.InsertarFinal(nodo1.Dato);
                nodo1 = nodo1.Sig;
            }
            while (nodo2 != null)
            {
                lista.InsertarFinal(nodo2.Dato);
                nodo2 = nodo2.Sig;
            }
            return lista;
        }
    }
}
