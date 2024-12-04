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
            while (!estaVacio())
            {
                Nodo sig = actual.Sig;
                actual.Sig = null;
                actual.Dato = null;
                actual = sig;
            }
            Cabeza = null;
            MessageBox.Show("La lista ha sido vaciada");
        }
        public override string ToString()
        {
            if (estaVacio())
                return "La lista está vacía.";

            Nodo actual = Cabeza;
            string resultado = "";

            while (actual != null)
            {
                resultado += actual.Dato + " -> ";
                actual = actual.Sig;
            }

            resultado += "null";
            return resultado;
        }
    }
}
