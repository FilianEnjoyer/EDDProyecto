using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class ListaSimple
    {
        public Nodo Cabeza;
        public ListaSimple()
        {
            Cabeza = null;
        }
        public bool estaVacio()
        {
            return Cabeza == null;
        }
        // Método para insertar al inicio de una lista
        public int InsertarInicio(string valor)
        {
            int operaciones = 0;
            Nodo Nuevo = new Nodo(valor);
            Nuevo.Sig = Cabeza;
            Cabeza = Nuevo;
            operaciones++;
            return operaciones;
        }

        // Método para insertar al final de una lista
        public int InsertarFinal(string valor)
        {
            int operaciones = 0;
            Nodo Nuevo = new Nodo(valor);
            operaciones++;

            if (Cabeza == null)
            {
                Cabeza = Nuevo;
                operaciones++;
            }
            else
            {
                Nodo Actual = Cabeza;
                while (Actual.Sig != null)
                {
                    Actual = Actual.Sig;
                    operaciones++;
                }
                Actual.Sig = Nuevo;
                operaciones++;
            }
            return operaciones;
        }

        // Método para insertar en una posición específica
        public int InsertarPos(string valor, int pos)
        {
            int operaciones = 0;
            pos = pos - 1;
            Nodo Nuevo = new Nodo(valor);
            operaciones++;

            if (pos == 0)
            {
                operaciones += InsertarInicio(valor);
            }
            else
            {
                Nodo Actual = Cabeza;
                int Contador = 0;
                while (Actual != null && Contador < pos - 1)
                {
                    Actual = Actual.Sig;
                    Contador++;
                    operaciones++;
                }

                if (Actual != null)
                {
                    Nuevo.Sig = Actual.Sig;
                    Actual.Sig = Nuevo;
                    operaciones += 2;
                }
                else
                {
                    Console.WriteLine("La posición excede el tamaño de la lista.");
                }
            }
            return operaciones;
        }

        // Método para eliminar el primer nodo
        public int EliminarTop()
        {
            int operaciones = 0;
            if (Cabeza != null)
            {
                Cabeza = Cabeza.Sig;
                operaciones++;
            }
            else
            {
                Console.WriteLine("La lista está vacía.");
            }
            return operaciones;
        }

        // Método para eliminar un valor específico
        public int EliminarValor(string valor)
        {
            int operaciones = 0;

            if (Cabeza == null) return operaciones;

            if (Cabeza.Dato == valor)
            {
                operaciones += EliminarTop();
                return operaciones;
            }

            Nodo Actual = Cabeza;
            while (Actual.Sig != null && Actual.Sig.Dato != valor)
            {
                Actual = Actual.Sig;
                operaciones++;
            }

            if (Actual.Sig != null)
            {
                Actual.Sig = Actual.Sig.Sig;
                operaciones++;
            }
            else
            {
                Console.WriteLine("Valor no encontrado.");
            }
            return operaciones;
        }

        // Método para buscar un valor específico
        public (int, int) Buscar(string valor)
        {
            Nodo Actual = Cabeza;
            int Pos = 1;
            int operaciones = 0;

            while (Actual != null)
            {
                operaciones++;
                if (Actual.Dato == valor) return (Pos, operaciones);
                Actual = Actual.Sig;
                Pos++;
            }

            Console.WriteLine("Valor no encontrado en la lista.");
            return (-1, operaciones);
        }

        // Método para recorrer la lista
        public (string, int) Recorrer()
        {
            int operaciones = 0;
            if (Cabeza == null)
            {
                operaciones++;
                return ("La lista está vacía.", operaciones);
            }

            Nodo Actual = Cabeza;
            string resultado = "";
            operaciones++;

            while (Actual != null)
            {
                resultado += Actual.Dato + " -> ";
                Actual = Actual.Sig;
                operaciones++;
            }
            resultado += "null";
            return (resultado, operaciones);
        }
        public void Vaciar()
        {
            if (estaVacio())
            {
                MessageBox.Show("La lista ya está vacía");
                return;
            }

            Nodo actual = Cabeza;

            // Recorremos la lista y eliminamos nodo por nodo
            while (actual != null)
            {
                Nodo sig = actual.Sig; // Guardamos la referencia al siguiente nodo
                actual.Sig = null;     // Desconectamos el nodo actual del siguiente
                actual = sig;          // Pasamos al siguiente nodo
            }

            // Finalmente, ponemos la cabeza en null
            Cabeza = null;
        }
        public void VaciarHash()
        {
            if (estaVacio())
            {
                return; // Si ya está vacía, salir del método sin mostrar mensaje
            }

            Nodo actual = Cabeza;

            // Recorremos la lista y eliminamos nodo por nodo
            while (actual != null)
            {
                Nodo sig = actual.Sig; // Guardamos la referencia al siguiente nodo
                actual.Sig = null;     // Desconectamos el nodo actual del siguiente
                actual = sig;          // Pasamos al siguiente nodo
            }

            // Finalmente, ponemos la cabeza en null
            Cabeza = null;
        }
        public override string ToString()
        {
            Nodo actual = Cabeza;
            StringBuilder resultado = new StringBuilder();

            while (actual != null)
            {
                if (resultado.Length > 0)
                    resultado.Append(" -> ");

                resultado.Append(actual.Dato);
                actual = actual.Sig;
            }

            resultado.Append(" -> null");
            return resultado.ToString();
        }
    }
}
