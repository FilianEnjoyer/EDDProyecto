using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_Ordenamiento.Clases
{
    public class Radix
    {
        public static void FuncionRadix(ListaSimple lista)
        {
            if (lista.estaVacio()) return;

            // Convertir ListaSimple a un arreglo de enteros
            List<int> valores = new List<int>();
            Nodo actual = lista.Cabeza;
            while (actual != null)
            {
                if (int.TryParse(actual.Dato, out int numero))
                {
                    valores.Add(numero);
                }
                actual = actual.Sig;
            }

            // Aplicar el algoritmo Radix Sort al arreglo
            int[] array = valores.ToArray();
            RadixSort(array);

            // Reemplazar los valores de la ListaSimple con los del arreglo ordenado
            lista.Vaciar();
            foreach (int numero in array)
            {
                lista.InsertarFinal(numero.ToString());
            }
        }

        // Método auxiliar para Radix Sort
        private static void RadixSort(int[] array)
        {
            int max = array.Max();
            int exp = 1;

            while (max / exp > 0)
            {
                CountSort(array, exp);
                exp *= 10;
            }
        }

        // Método de conteo para Radix Sort
        private static void CountSort(int[] array, int exp)
        {
            int n = array.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                count[(array[i] / exp) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(array[i] / exp) % 10] - 1] = array[i];
                count[(array[i] / exp) % 10]--;
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
            }
        }
    }
}
