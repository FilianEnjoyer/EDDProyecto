using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L label=\"L\"] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }
            else
            {
                b.AppendFormat("{0}->L{1} [side=L, style=\"invis\" label=\"L\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("L{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R label=\"R\"] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            else
            {
                b.AppendFormat("{0}->R{1} [side=R, style=\"invis\" label=\"R\"] {2} ", nodo.Dato.ToString(), nodo.Dato.ToString(), Environment.NewLine);
                b.AppendFormat("R{0}[style = \"invisible\" shape = none] {1} ", nodo.Dato.ToString(), Environment.NewLine);

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
        public void podaArbol()
        {
            if (Raiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }
            PodarArbol(ref Raiz);
            Raiz = null;
        }
        public void limpiaArbol()
        {
            if (Raiz == null)
            {
                return;
            }
            PodarArbol(ref Raiz);
            Raiz = null;
        }
        public void PodarArbol(ref NodoBinario Nodo)
        {
            if (Raiz == null)
            {
                return;
            }
            if (Nodo.Izq != null) PodarArbol(ref Nodo.Izq);
            if (Nodo.Der != null) PodarArbol(ref Nodo.Der);
            Nodo.Izq = null;
            Nodo.Der = null;
        }
        public NodoBinario BuscarMinimo(NodoBinario nodo)
        {
            if (nodo == null)
                return null;
            else if (nodo.Izq == null)
                return nodo;
            else
                return BuscarMinimo(nodo.Izq);
        }

        public NodoBinario BuscarMaximo(NodoBinario nodo)
        {
            if (nodo == null)
                return null;
            else if (nodo.Der == null)
                return nodo;
            else
                return BuscarMaximo(nodo.Der);
        }
        public void EliminarNodo(int dato, ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            if (dato < nodo.Dato)
                EliminarNodo(dato, ref nodo.Izq);
            else if (dato > nodo.Dato)
                EliminarNodo(dato, ref nodo.Der);
            else
            {
                if (nodo.Izq == null)
                {
                    NodoBinario temp = nodo;
                    nodo = nodo.Der;
                    temp = null; // El recolector de basura se encargará de esto
                }
                else if (nodo.Der == null)
                {
                    NodoBinario temp = nodo;
                    nodo = nodo.Izq;
                    temp = null; // El recolector de basura se encargará de esto
                }
                else
                {
                    NodoBinario temp = BuscarMinimo(nodo.Der);
                    nodo.Dato = temp.Dato;
                    EliminarNodo(temp.Dato, ref nodo.Der);
                }
            }
        }
        public void EliminarPredecesor(int dato, ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            if (dato < nodo.Dato)
                EliminarPredecesor(dato, ref nodo.Izq);
            else if (dato > nodo.Dato)
                EliminarPredecesor(dato, ref nodo.Der);
            else
            {
                if (nodo.Izq == null)
                {
                    // El nodo a eliminar no tiene predecesor
                    MessageBox.Show("El nodo no tiene predecesor");
                    return;
                }
                else
                {
                    // Encontrar el mayor del subárbol izquierdo (predecesor)
                    NodoBinario predecesor = BuscarMaximo(nodo.Izq);
                    // Copiar el valor del predecesor al nodo actual
                    nodo.Dato = predecesor.Dato;
                    // Eliminar el predecesor del subárbol izquierdo
                    EliminarNodo(predecesor.Dato, ref nodo.Izq);
                }
            }
        }

        public void EliminarSucesor(int dato, ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            if (dato < nodo.Dato)
                EliminarSucesor(dato, ref nodo.Izq);
            else if (dato > nodo.Dato)
                EliminarSucesor(dato, ref nodo.Der);
            else
            {
                if (nodo.Der == null)
                {
                    // El nodo a eliminar no tiene sucesor
                    MessageBox.Show("El nodo no tiene sucesor");
                    return;
                }
                else
                {
                    // Encontrar el menor del subárbol derecho (sucesor)
                    NodoBinario sucesor = BuscarMinimo(nodo.Der);
                    // Copiar el valor del sucesor al nodo actual
                    nodo.Dato = sucesor.Dato;
                    // Eliminar el sucesor del subárbol derecho   

                    EliminarNodo(sucesor.Dato, ref nodo.Der);
                }
            }
        }
        
        public int altura(NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                return 0;
            }

            return 1 + Math.Max(altura(Nodo.Izq), altura(Nodo.Der));
        }

        public int contarHojas(NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                return 0;
            }

            if (Nodo.Der == null && Nodo.Izq == null)
            {
                return 1;
            }
            else
            {
                return contarHojas(Nodo.Izq) + contarHojas(Nodo.Der);

            }
        }

        public int contarNodos(NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                return 0;
            }

            return 1 + contarNodos(Nodo.Izq) + contarNodos(Nodo.Der);

        }
        public bool esLleno(NodoBinario Nodo)
        {
            if (Nodo == null)
                return true;
            if (Nodo.Der == null && Nodo.Izq == null)
                return true;
            if (Nodo.Der != null && Nodo.Izq != null)
                return (esLleno(Nodo.Izq) && esLleno(Nodo.Der));
            return false;
        }


        public void RecorridoPorNiveles(NodoBinario nodo)
        {
            // Verificamos si el nodo inicial es null; si es así, no hay nada que recorrer y salimos del método
            if (nodo == null) return;

            // Creamos una cola para almacenar los nodos del árbol y procesarlos en orden de nivel
            Queue<NodoBinario> cola = new Queue<NodoBinario>();

            // Encolamos el nodo raíz para iniciar el recorrido
            cola.Enqueue(nodo);

            // Bucle que continúa mientras haya nodos en la cola
            while (cola.Count > 0)
            {
                // Desencolamos el nodo al frente de la cola y lo almacenamos en 'actual'
                NodoBinario actual = cola.Dequeue();

                // Añadimos el valor del nodo actual a la cadena 'strRecorrido', seguido de una coma y un espacio
                strRecorrido += actual.Dato + ", ";

                // Si el nodo actual tiene un hijo izquierdo, lo encolamos para procesarlo en el futuro
                if (actual.Izq != null)
                    cola.Enqueue(actual.Izq);

                // Si el nodo actual tiene un hijo derecho, lo encolamos para procesarlo en el futuro
                if (actual.Der != null)
                    cola.Enqueue(actual.Der);
            }

            /* Nota: La variable 'strRecorrido' contendrá una lista de valores de los nodos
            en el orden de niveles, separados por comas. Podríamos eliminar la última coma
            si deseamos un formato más limpio.*/
        }

        public bool esCompleto(NodoBinario nodoPtr)
        {
            // Verifica si el árbol está vacío; si es así, es completo por definición
            if (nodoPtr == null)
                return true; // Un árbol vacío es completo

            // Creamos una cola auxiliar para realizar el recorrido por niveles
            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();

            // Encolamos el nodo raíz para iniciar el recorrido
            colaAuxiliar.Enqueue(nodoPtr);

            // Variable que indica si hemos encontrado un nodo incompleto (es decir, un nodo que
            // no tiene ambos hijos). Esto nos ayuda a verificar la condición de completitud del árbol.
            bool nodoIncompleto = false;

            // Bucle que continúa mientras haya nodos en la cola
            while (colaAuxiliar.Count > 0)
            {
                // Desencolamos el nodo al frente de la cola y lo almacenamos en 'actual'
                NodoBinario actual = colaAuxiliar.Dequeue();

                // Verifica el hijo izquierdo del nodo actual
                if (actual.Izq != null)
                {
                    // Si hemos encontrado un nodo incompleto anteriormente, el árbol no es completo
                    if (nodoIncompleto)
                        return false;

                    // Encolamos el hijo izquierdo para procesarlo en el futuro
                    colaAuxiliar.Enqueue(actual.Izq);
                }
                else
                {
                    // Si el nodo no tiene hijo izquierdo, marcamos que hemos encontrado un nodo incompleto
                    nodoIncompleto = true;
                }

                // Verifica el hijo derecho del nodo actual
                if (actual.Der != null)
                {
                    // Si hemos encontrado un nodo incompleto anteriormente, el árbol no es completo
                    if (nodoIncompleto)
                        return false;

                    // Encolamos el hijo derecho para procesarlo en el futuro
                    colaAuxiliar.Enqueue(actual.Der);
                }
                else
                {
                    // Si el nodo no tiene hijo derecho, marcamos que hemos encontrado un nodo incompleto
                    nodoIncompleto = true;
                }
            }

            // Si el recorrido se completa sin encontrar inconsistencias, el árbol es completo
            return true;
        }


    }
}
