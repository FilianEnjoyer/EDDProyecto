using EDDemo.Estructuras_No_Lineales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class Cola
    {

        public Nodo first;
        public Nodo last;

        public Cola()
        {
            first = null;
            last = null;
        }
        public bool estaVacio()
        {
            return first == null;
        }
        // Método para encolar (Queue)
        public int Queue(string dato)
        {
            int operaciones = 0;
            Nodo nuevo = new Nodo(dato);
            operaciones++;

            if (last == null)
            {
                last = nuevo;
                first = nuevo;
                operaciones += 2;
            }
            else
            {
                last.Sig = nuevo;
                last = nuevo;
                operaciones += 2;
            }
            return operaciones;
        }

        // Método para desencolar (Dequeue)
        public (string, int) Dequeue()
        {
            int operaciones = 0;
            if (first == null)
            {
                operaciones++;
                return ("Cola vacía", operaciones);
            }
            else
            {
                Nodo temp = first;
                first = first.Sig;
                string dato = temp.Dato;
                operaciones += 2;

                if (first == null)
                {
                    last = null;
                    operaciones++;
                }
                return (dato, operaciones);
            }
        }

        // Método para buscar un elemento en la cola
        public (int, int) Buscar(string valor)
        {
            int operaciones = 0;
            if (first == null) return (-1, operaciones);

            Nodo actual = first;
            int pos = 1;
            operaciones++;

            while (actual != null)
            {
                operaciones++;
                if (actual.Dato == valor)
                {
                    return (pos, operaciones);
                }
                actual = actual.Sig;
                pos++;
            }
            return (-1, operaciones); // No encontrado
        }

        // Método para recorrer la cola
        public (string, int) Recorrer()
        {
            int operaciones = 0;
            if (first == null) return ("Cola vacía", operaciones);

            Nodo actual = first;
            string resultado = "";
            operaciones++;

            while (actual != null)
            {
                resultado += actual.Dato + " -> ";
                actual = actual.Sig;
                operaciones++;
            }
            resultado += "Null";
            return (resultado, operaciones);
        }
        public void Vaciar()
        {
            if (estaVacio())
            {
                MessageBox.Show("La cola ya está vacía");
                return;
            }

            // Mientras haya nodos, dequeue a cada uno
            while (!estaVacio())
            {
                Dequeue();
            }

            MessageBox.Show("La cola ha sido vaciada");
        }
    }
}
