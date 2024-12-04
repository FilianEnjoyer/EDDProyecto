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
    public partial class FrmMezclaDirecta : Form
    {
        ListaSimple lista = new ListaSimple();
        public FrmMezclaDirecta()
        {
            InitializeComponent();
        }

        private void BtnGenerarLista_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(txtCantidad1.Text, out cantidad) && cantidad > 0)
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

                TxtLista.Text = listaTexto;
            }
            else
            {
                MessageBox.Show("Ingresa un número");
            }
        }

        private void BtnOrdenarLista_Click(object sender, EventArgs e)
        {
            string[] numerosTexto = TxtLista.Text.Split(new string[] { ", " }, StringSplitOptions.None);

            // Insertamos los números en la lista enlazada
            foreach (var numero in numerosTexto)
            {
                lista.InsertarFinal(numero);  // Insertamos al final de la lista
            }

            // Usamos un cronómetro para medir el tiempo de ejecución
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Llamamos al algoritmo Mezcla Directa para ordenar la lista
            lista = MezclaDirecta.MezclaDire(lista);

            stopwatch.Stop();

            // Mostramos la lista ordenada en txtOrdenado
            TxtListaOrdenada.Text = lista.ToString();  // Usamos ToString para mostrar los números ordenados

            // Mostramos el tiempo de ejecución en el TextBox txtTiempo
            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }
    }
}
