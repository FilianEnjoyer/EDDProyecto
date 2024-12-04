using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Ordenamiento.Clases
{
    public class MezclaNatural
    {
        // Función para mezclar dos listas ordenadas
        public static ListaSimple Mezclar(ListaSimple lista1, ListaSimple lista2)
        {
            ListaSimple listaFusionada = new ListaSimple();
            Nodo actual1 = lista1.Cabeza;
            Nodo actual2 = lista2.Cabeza;

            // Fusionamos las dos listas ordenadas
            while (actual1 != null && actual2 != null)
            {
                if (int.Parse(actual1.Dato) <= int.Parse(actual2.Dato))
                {
                    listaFusionada.InsertarFinal(actual1.Dato); // Insertamos el valor de la primera lista
                    actual1 = actual1.Sig;
                }
                else
                {
                    listaFusionada.InsertarFinal(actual2.Dato); // Insertamos el valor de la segunda lista
                    actual2 = actual2.Sig;
                }
            }

            // Si alguna lista tiene elementos restantes, los agregamos
            while (actual1 != null)
            {
                listaFusionada.InsertarFinal(actual1.Dato);
                actual1 = actual1.Sig;
            }

            while (actual2 != null)
            {
                listaFusionada.InsertarFinal(actual2.Dato);
                actual2 = actual2.Sig;
            }

            return listaFusionada;
        }

        // Identificar runs (subsecuencias ordenadas en la lista)
        public static List<ListaSimple> IdentificarRuns(ListaSimple lista)
        {
            List<ListaSimple> runs = new List<ListaSimple>();
            if (lista.estaVacio()) return runs;

            Nodo actual = lista.Cabeza;
            ListaSimple subsecuencia = new ListaSimple();
            subsecuencia.InsertarFinal(actual.Dato);

            while (actual.Sig != null)
            {
                if (int.Parse(actual.Sig.Dato) >= int.Parse(actual.Dato))
                {
                    // La subsecuencia sigue ordenada, añadimos el siguiente valor
                    subsecuencia.InsertarFinal(actual.Sig.Dato);
                }
                else
                {
                    // Fin de la subsecuencia, la añadimos y comenzamos una nueva
                    runs.Add(subsecuencia);
                    subsecuencia = new ListaSimple();
                    subsecuencia.InsertarFinal(actual.Sig.Dato);
                }
                actual = actual.Sig;
            }
            runs.Add(subsecuencia); // Añadimos la última subsecuencia
            return runs;
        }

        // Función principal de Mezcla Natural
        public static ListaSimple FuncionMezclaNatural(ListaSimple lista)
        {
            List<ListaSimple> subsecuencias = IdentificarRuns(lista); // Dividimos en subsecuencias ordenadas

            while (subsecuencias.Count > 1)
            {
                // Fusionamos las dos primeras subsecuencias
                ListaSimple listaFusionada = Mezclar(subsecuencias[0], subsecuencias[1]);
                subsecuencias.RemoveAt(0); // Eliminamos las subsecuencias fusionadas
                subsecuencias.RemoveAt(0);
                subsecuencias.Insert(0, listaFusionada); // Insertamos la lista fusionada al inicio
            }

            return subsecuencias[0]; // Devolvemos la lista ordenada final
        }
    }
}
