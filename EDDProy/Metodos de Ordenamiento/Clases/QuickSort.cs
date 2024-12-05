using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Ordenamiento.Clases
{
    public class QuickSort
    {
        // Método principal que adapta Quicksort para ListaSimple
        public static void FuncionQuicksort(ListaSimple lista)
        {
            if (lista.estaVacio()) return;

            // Convertir la lista a un arreglo
            int[] arreglo = ConvertirListaAArreglo(lista);

            // Aplicar Quicksort al arreglo
            QuicksortRecursivo(arreglo, 0, arreglo.Length - 1);

            // Reconstruir la lista con los elementos ordenados
            ReconstruirListaDesdeArreglo(lista, arreglo);
        }

        // Función recursiva de Quicksort
        private static void QuicksortRecursivo(int[] A, int inf, int sup)
        {
            if (inf >= sup)
                return;

            int i = inf;
            int j = sup;
            int pivote = A[(inf + sup) / 2]; // Elemento pivote

            while (i <= j)
            {
                // Buscar un elemento en la izquierda mayor que el pivote
                while (A[i] < pivote)
                    i++;

                // Buscar un elemento en la derecha menor que el pivote
                while (A[j] > pivote)
                    j--;

                // Si los índices no se han cruzado, intercambiar los elementos
                if (i <= j)
                {
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                    i++;
                    j--;
                }
            }

            // Llamadas recursivas para ordenar las sublistas
            if (inf < j)
                QuicksortRecursivo(A, inf, j);

            if (i < sup)
                QuicksortRecursivo(A, i, sup);
        }

        // Convertir una ListaSimple a un arreglo de enteros
        private static int[] ConvertirListaAArreglo(ListaSimple lista)
        {
            List<int> elementos = new List<int>();
            Nodo actual = lista.Cabeza;

            while (actual != null)
            {
                elementos.Add(int.Parse(actual.Dato)); // Convertimos cada dato a entero
                actual = actual.Sig;
            }

            return elementos.ToArray();
        }

        // Reconstruir la lista desde un arreglo de enteros
        private static void ReconstruirListaDesdeArreglo(ListaSimple lista, int[] arreglo)
        {
            lista.Vaciar(); // Vaciar la lista original

            foreach (int elemento in arreglo)
            {
                lista.InsertarFinal(elemento.ToString()); // Insertar cada elemento en la lista como cadena
            }
        }
    }
}
