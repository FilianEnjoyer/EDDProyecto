using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class ListaCircularDoble
    {
        public Nodo Inicio;
        public Nodo Fin;

        public ListaCircularDoble()
        {
            Inicio = null;
            Fin = null;
        }
        public bool estaVacio()
        {
            return Inicio == null && Fin == null;
        }
        public int Insertar(string dato, int posicion)
        {
            Nodo nuevo = new Nodo(dato);
            int operaciones = 0;

            // Caso 1: Lista vacía
            if (Inicio == null && Fin == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
                Fin.Sig = Inicio; // Mantener la circularidad
                operaciones++;
                return operaciones;
            }

            // Caso 2: Insertar en la primera posición
            if (posicion == 0 || posicion == 1)
            {
                nuevo.Sig = Inicio;
                Inicio = nuevo;
                Fin.Sig = Inicio; // Mantener la circularidad
                operaciones += 2;
                return operaciones;
            }

            // Caso 3: Insertar en una posición mayor
            int pos = 1;
            Nodo aux = Inicio;
            Nodo previo = null;

            while (pos < posicion && aux.Sig != Inicio)
            {
                previo = aux;
                aux = aux.Sig;
                pos++;
                operaciones++;
            }

            // Si la posición es válida
            if (pos == posicion)
            {
                nuevo.Sig = aux;
                if (previo != null)
                {
                    previo.Sig = nuevo;
                }
                operaciones++;

                if (aux == Inicio) // Si es el último nodo
                {
                    Fin = nuevo;
                    operaciones++;
                }
            }
            else if (aux.Sig == Inicio) // Insertar al final
            {
                Fin.Sig = nuevo;
                nuevo.Sig = Inicio;
                Fin = nuevo;
                operaciones++;
            }
            else
            {
                Console.WriteLine("Posición fuera de rango");
            }

            return operaciones;
        }

        // Método para recorrer e imprimir la lista
        public (string, int) Recorrer()
        {
            string resultado = "";
            int operaciones = 0;

            if (Inicio == null)
            {
                return ("La lista está vacía", operaciones);
            }

            Nodo temp = Inicio;
            do
            {
                resultado += temp.Dato + " -> ";
                temp = temp.Sig;
                operaciones++;
            }
            while (temp != Inicio);

            resultado += "Circular";
            return (resultado, operaciones);
        }

        // Método para eliminar un nodo en una posición específica
        public int Eliminar(int posicion)
        {
            int operaciones = 0;

            if (Inicio == null)
            {
                Console.WriteLine("Lista vacía");
                return operaciones;
            }

            Nodo aux = Inicio;
            Nodo previo = null;
            int pos = 1;

            while (pos < posicion && aux.Sig != Inicio)
            {
                previo = aux;
                aux = aux.Sig;
                pos++;
                operaciones++;
            }

            if (pos == posicion)
            {
                if (aux == Inicio && aux == Fin) // Lista con un solo nodo
                {
                    Inicio = null;
                    Fin = null;
                    operaciones++;
                }
                else if (aux == Inicio) // Eliminar el primer nodo
                {
                    Inicio = aux.Sig;
                    Fin.Sig = Inicio;
                    operaciones++;
                }
                else if (aux == Fin) // Eliminar el último nodo
                {
                    Fin = previo;
                    Fin.Sig = Inicio;
                    operaciones++;
                }
                else // Eliminar un nodo intermedio
                {
                    previo.Sig = aux.Sig;
                    operaciones++;
                }
            }
            else
            {
                Console.WriteLine("Posición fuera de rango");
            }

            return operaciones;
        }

        // Método para buscar un valor y devolver su posición
        public (int, int) Buscar(string valor)
        {
            int operaciones = 0;
            if (Inicio == null)
            {
                Console.WriteLine("La lista está vacía");
                return (-1, operaciones);
            }

            Nodo temp = Inicio;
            int pos = 1;

            do
            {
                operaciones++;
                if (temp.Dato == valor)
                {
                    return (pos, operaciones);
                }
                temp = temp.Sig;
                pos++;
            }
            while (temp != Inicio);

            Console.WriteLine("Valor no encontrado");
            return (-1, operaciones);
        }
    }
}
