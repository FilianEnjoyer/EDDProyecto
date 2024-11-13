using EDDemo.Estructuras_No_Lineales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class Cola<T>
    {
        private NodoCola<T> first;
        private NodoCola<T> last;
        public Cola()
        {
            first = null;
            last = null;
        }
        public void Queue(T Dato)
        {
            NodoCola<T> nuevo = new NodoCola<T>(Dato);
            if (last == null)
            {
                last = nuevo;
                first = nuevo;
            }
            else
            {
                last.Sig = nuevo;
                last = nuevo; // Actualizar el puntero last
            }
        }
        

        public T Dequeue()
        {
            if (first == null)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
            else
            {
                NodoCola<T> temp = first;
                first = temp.Sig;
                T Dato = temp.Dato;
                temp = null;
                return Dato;
            }
        }

        public void Buscar(T valor)
        {
            if (first == null)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
            else
            {
                int pos = 1;
                NodoCola<T> actual = first;

                // Para comparar dos objetos de tipo T, usamos Equals en lugar de '=='
                while (actual != null && !actual.Dato.Equals(valor))
                {
                    actual = actual.Sig;
                    pos++;
                }

                if (actual == null)
                {
                    Console.WriteLine("El dato {0} no se encuentra en la lista", valor);
                }
                else
                {
                    Console.WriteLine("El dato {0} se encuentra en la posición {1}", valor, pos);
                }
            }
        }

        public void Recorrer()
        {
            if (first == null)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                NodoCola<T> actual = first;
                while (actual != null)
                {
                    Console.WriteLine("{0}", actual.Dato);
                    actual = actual.Sig;
                }
                Console.WriteLine("Null");
            }
        }
        public int Contar()
        {
            if (first == null) return 0;
            else
            {
                NodoCola<T> actual = first;
                int contador = 0;

                while (actual != null)
                {
                    actual = actual.Sig;
                    contador++;
                }

                return contador;
            }
        }
    }
}
