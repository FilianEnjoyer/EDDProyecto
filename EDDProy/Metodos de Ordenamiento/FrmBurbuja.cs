using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Metodos_de_Ordenamiento.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_Ordenamiento
{
    public partial class FrmBurbuja : Form
    {
        ListaSimple lista = new ListaSimple();
        public FrmBurbuja()
        {
            InitializeComponent();
        }

        private void btnGenerarLista_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(txtInPut.Text, out cantidad) && cantidad > 0)
            {
                Random random = new Random();
                string listaTexto = "";

                for (int i = 0; i < cantidad; i++)
                {
                    int numero = random.Next(1, 100);

                    if (i > 0)
                    {
                        listaTexto += ", ";
                    }

                    listaTexto += numero.ToString();
                }

                txtLista.Text = listaTexto;
            }
            else
            {
                MessageBox.Show("Ingresa un número");
            }
        }

        private void btnOrdenarLista_Click(object sender, EventArgs e)
        {
            // Convertimos la lista de texto en la lista vinculada (ListaSimple)
            string[] numerosTexto = txtLista.Text.Split(new string[] { ", " }, StringSplitOptions.None);


            // Insertamos los números en la lista
            foreach (var numero in numerosTexto)
            {
                lista.InsertarFinal(numero); // Usa el método InsertarFinal para agregar nodos
            }

            // Creamos el cronómetro para medir el tiempo de ejecución
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Llamamos a la función de burbuja con la lista
            Burbuja.OrdenarBurbuja(lista);

            stopwatch.Stop();

            // Mostramos los resultados ordenados
            txtListaOrdenada.Text = lista.ToString(); // Llama al método ToString() de la clase ListaSimple

            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }
        private void ActualizarLista()
        {
            var (recorrido, _) = lista.Recorrer();
            txtLista.Text = recorrido;  // Mostrar el contenido de la lista en el TextBox de resultados
        }
    }
}
