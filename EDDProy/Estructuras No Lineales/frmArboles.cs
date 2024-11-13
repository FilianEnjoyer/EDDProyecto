using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text),
                                ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";
            // Llama a los métodos de tu árbol y actualiza las etiquetas
            int altura = miArbol.altura(miRaiz);
            int contarHojas = miArbol.contarHojas(miRaiz);
            int contarNodos = miArbol.contarNodos(miRaiz);

            // Actualiza las etiquetas con los resultados
            lblAltura.Text = "Altura: " + altura;
            lblHojas.Text = "Hojas: " + contarHojas;
            lblNodos.Text = "Nodos: " + contarNodos;
            
            bool Com = miArbol.esCompleto(miRaiz);
            if (Com == true)
            {
                lblCompleto.Text = "Completo: Verdadero";
            }
            else
            {
                lblCompleto.Text = "Completo: Falso";
            }
            bool llen = miArbol.esLleno(miRaiz);
            if (llen == true)
            {
                lblLleno.Text = "Lleno: Verdadero";
            }
            else
            {
                lblLleno.Text = "Lleno: Falso";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (miArbol != null)
            {
                // Llama al método para podar el árbol
                miArbol.podaArbol();
            }

            // Reinicia el árbol, creando una nueva instancia después de podarlo
            miArbol = new ArbolBusqueda();

            // Limpia los elementos de la interfaz
            txtArbol.Text = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
            lblRecorridoPorNivel.Text = "";
            // Actualiza las etiquetas con los resultados
            lblAltura.Text = "Altura: ";
            lblHojas.Text = "Hojas: ";
            lblNodos.Text = "Nodos: ";
            bool Com = miArbol.esCompleto(miRaiz);
            if (Com == true)
            {
                lblCompleto.Text = "Completo: Verdadero";
            }
            else
            {
                lblCompleto.Text = "Completo: Falso";
            }
            bool llen = miArbol.esLleno(miRaiz);
            if (llen == true)
            {
                lblLleno.Text = "Lleno: Verdadero";
            }
            else
            {
                lblLleno.Text = "Lleno: Falso";
            }
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null) {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = ""; 
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPorNivel.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPorNivel.Text = "";
            miArbol.RecorridoPorNiveles(miRaiz);
            lblRecorridoPorNivel.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            if (miArbol != null)
            {
                // Llama al método para limpiar el árbol anterior
                miArbol.limpiaArbol();
            }

            // Reinicia el árbol, creando una nueva instancia después de podarlo
            miArbol = new ArbolBusqueda();

            // Limpia los elementos de la interfaz
            txtArbol.Text = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
            lblRecorridoPorNivel.Text = "";
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
             
            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos =1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodoAleatorio(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
            // Llama a los métodos de tu árbol y actualiza las etiquetas
            int altura = miArbol.altura(miRaiz);
            int contarHojas = miArbol.contarHojas(miRaiz);
            int contarNodos = miArbol.contarNodos(miRaiz);

            // Actualiza las etiquetas con los resultados
            lblAltura.Text = "Altura: " + altura;
            lblHojas.Text = "Hojas: " + contarHojas;
            lblNodos.Text = "Nodos: " + contarNodos;
            bool Com = miArbol.esCompleto(miRaiz);
            if (Com == true)
            {
                lblCompleto.Text = "Completo: Verdadero";
            }
            else
            {
                lblCompleto.Text = "Completo: Falso";
            }
            bool llen = miArbol.esLleno(miRaiz);
            if (llen == true)
            {
                lblLleno.Text = "Lleno: Verdadero";
            }
            else
            {
                lblLleno.Text = "Lleno: Falso";
            }
        }

        private void btBuscarNodo_Click(object sender, EventArgs e)
        {
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.BuscarNodo(int.Parse(txtDato.Text));
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void BtEliminarPre_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            miArbol.EliminarPredecesor(int.Parse(txtDato.Text), ref miRaiz);
            txtArbol.Clear();
            txtDato.Clear();
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            // Llama a los métodos de tu árbol y actualiza las etiquetas
            int altura = miArbol.altura(miRaiz);
            int contarHojas = miArbol.contarHojas(miRaiz);
            int contarNodos = miArbol.contarNodos(miRaiz);

            // Actualiza las etiquetas con los resultados
            lblAltura.Text = "Altura: " + altura;
            lblHojas.Text = "Hojas: " + contarHojas;
            lblNodos.Text = "Nodos: " + contarNodos;
            bool Com = miArbol.esCompleto(miRaiz);
            if (Com == true)
            {
                lblCompleto.Text = "Completo: Verdadero";
            }
            else
            {
                lblCompleto.Text = "Completo: Falso";
            }
            bool llen = miArbol.esLleno(miRaiz);
            if (llen == true)
            {
                lblLleno.Text = "Lleno: Verdadero";
            }
            else
            {
                lblLleno.Text = "Lleno: Falso";
            }
        }

        private void BtEliminarSuce_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            miArbol.EliminarSucesor(int.Parse(txtDato.Text), ref miRaiz);
            txtArbol.Clear();
            txtDato.Clear();
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            // Llama a los métodos de tu árbol y actualiza las etiquetas
            int altura = miArbol.altura(miRaiz);
            int contarHojas = miArbol.contarHojas(miRaiz);
            int contarNodos = miArbol.contarNodos(miRaiz);

            // Actualiza las etiquetas con los resultados
            lblAltura.Text = "Altura: " + altura;
            lblHojas.Text = "Hojas: " + contarHojas;
            lblNodos.Text = "Nodos: " + contarNodos;
            bool Com = miArbol.esCompleto(miRaiz);
            if (Com == true)
            {
                lblCompleto.Text = "Completo: Verdadero";
            }
            else
            {
                lblCompleto.Text = "Completo: Falso";
            }
            bool llen = miArbol.esLleno(miRaiz);
            if (llen == true)
            {
                lblLleno.Text = "Lleno: Verdadero";
            }
            else
            {
                lblLleno.Text = "Lleno: Falso";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
