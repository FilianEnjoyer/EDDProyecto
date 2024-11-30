using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListaDoble
    {
        public NodoDoble Start;
        public NodoDoble End;

        public ListaDoble()
        {
            Start = null;
            End = null;
        }
        public bool estaVacio()
        {
            return Start == null;
        }
        // Método para insertar en una posición específica
        public int Insertar(string valor, int pos)
        {
            int operaciones = 0;
            NodoDoble nuevo = new NodoDoble(valor);
            operaciones++;

            if (Start == null)
            {
                Start = nuevo;
                End = nuevo;
                operaciones++;
            }
            else
            {
                if (pos == 0)
                {
                    nuevo.Sig = Start;
                    Start.Ant = nuevo;
                    Start = nuevo;
                    operaciones += 2;
                }
                else
                {
                    NodoDoble temp = Start;
                    int indicador = 0;
                    while (temp != null && indicador < pos)
                    {
                        temp = temp.Sig;
                        indicador++;
                        operaciones++;
                    }

                    if (temp != null)
                    {
                        nuevo.Sig = temp;
                        nuevo.Ant = temp.Ant;
                        if (temp.Ant != null) temp.Ant.Sig = nuevo;
                        temp.Ant = nuevo;
                        operaciones += 2;
                    }
                    else
                    {
                        End.Sig = nuevo;
                        nuevo.Ant = End;
                        End = nuevo;
                        operaciones++;
                    }
                }
            }
            return operaciones;
        }

        // Método para recorrer la lista hacia adelante
        public (string, int) RecorrerAdelante()
        {
            int operaciones = 0;
            if (Start == null)
            {
                return ("Lista vacía", operaciones);
            }

            NodoDoble temp = Start;
            string resultado = "";
            operaciones++;

            while (temp != null)
            {
                resultado += temp.Dato + " -> ";
                temp = temp.Sig;
                operaciones++;
            }
            resultado += "null";
            return (resultado, operaciones);
        }

        // Método para recorrer la lista hacia atrás
        public (string, int) RecorrerAtras()
        {
            int operaciones = 0;
            if (End == null)
            {
                return ("Lista vacía", operaciones);
            }

            NodoDoble temp = End;
            string resultado = "";
            operaciones++;

            while (temp != null)
            {
                resultado += temp.Dato + " -> ";
                temp = temp.Ant;
                operaciones++;
            }
            resultado += "null";
            return (resultado, operaciones);
        }

        // Método para eliminar en una posición específica
        public int Eliminar(int pos)
        {
            int operaciones = 0;
            if (Start == null) return operaciones;

            NodoDoble temp = Start;
            int contador = 0;

            while (temp != null && contador < pos)
            {
                temp = temp.Sig;
                contador++;
                operaciones++;
            }

            if (temp != null)
            {
                if (temp == Start) Start = temp.Sig;
                if (temp == End) End = temp.Ant;
                if (temp.Sig != null) temp.Sig.Ant = temp.Ant;
                if (temp.Ant != null) temp.Ant.Sig = temp.Sig;
                operaciones++;
            }
            return operaciones;
        }

        // Método para buscar un valor en la lista
        public (int, int) Buscar(string valor)
        {
            int operaciones = 0;
            NodoDoble temp = Start;
            int posicion = 1;

            while (temp != null)
            {
                operaciones++;
                if (temp.Dato == valor) return (posicion, operaciones);
                temp = temp.Sig;
                posicion++;
            }
            return (-1, operaciones);
        }
    }
}
