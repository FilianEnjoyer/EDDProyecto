using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Ordenamiento.Clases
{
    public class ShellSort
    {
        public static void FuncionShellSort(ListaSimple lista)
        {
            if (lista.estaVacio()) return;

            // Convertir la lista a un arreglo
            int[] valores = ConvertirListaAArreglo(lista);

            // Aplicar el algoritmo Shellsort
            Shellsort(valores);

            // Reconstruir la lista con los elementos ordenados
            ReconstruirListaDesdeArreglo(lista, valores);
        }

        // Implementación del algoritmo Shellsort
        private static void Shellsort(int[] valores)
        {
            int n = valores.Length;

            // Inicializamos el gap
            int gap = n / 2;

            // Mientras el gap sea mayor a 0
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = valores[i];
                    int j = i;

                    // Comparación e intercambio utilizando el gap
                    while (j >= gap && valores[j - gap] > temp)
                    {
                        valores[j] = valores[j - gap];
                        j -= gap;
                    }

                    valores[j] = temp;
                }

                // Reducimos el gap
                gap /= 2;
            }
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
