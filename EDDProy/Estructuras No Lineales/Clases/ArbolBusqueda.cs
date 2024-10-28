using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Busqueda(Dato, Raiz) == false)
            {
                if (Nodo == null)
                {
                    Nodo = new NodoBinario(Dato);
                    // CAMBIO 2

                    if (Raiz == null)
                        Raiz = Nodo;
                }
                else if (Dato < Nodo.Dato)
                    InsertaNodo(Dato, ref Nodo.Izq);
                else if (Dato > Nodo.Dato)
                    InsertaNodo(Dato, ref Nodo.Der);
            }
            else
            {
                MessageBox.Show("El dato ya se encuentra en el arbol");
                return;
            }
                     
        }
        public void InsertaNodoAleatorio(int Dato, ref NodoBinario Nodo)
        {
            
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodoAleatorio(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodoAleatorio(Dato, ref Nodo.Der);
            

        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo )
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for(int i=0; i<nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public  String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);
            
            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo )
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
         }
        public Boolean Busqueda (int Dato, NodoBinario nodo)
        {
            if (nodo == null) return false;
            if (Dato < nodo.Dato) return Busqueda(Dato, nodo.Izq);
            if (Dato > nodo.Dato) return Busqueda(Dato, nodo.Der);
            return true;
        }
        public void BuscarNodo(int Valor)
        {
            if (Raiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }
            NodoBinario miRaiz = Raiz;
            if (Busqueda(Valor, miRaiz) == true)
            {
                MessageBox.Show ("Se ha encontrado el dato");
                return;
            }
            else
            {
                MessageBox.Show("Valor no encontrado");
                return;
            }
        }

    }
}
