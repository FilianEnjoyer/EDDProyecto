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
    public partial class FrmShellSort : Form
    {
        public FrmShellSort()
        {
            InitializeComponent();
        }
        private void BtnGenerarLista_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(TxtNumeroElementos.Text, out cantidad) && cantidad > 0)
            {
                ListaSimple lista = new ListaSimple();
                Random random = new Random();

                for (int i = 0; i < cantidad; i++)
                {
                    int numero = random.Next(1, 100);
                    lista.InsertarFinal(numero.ToString());
                }

                // Mostrar la lista generada en el TextBox
                TxtLista.Text = lista.ToString();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }
        private ListaSimple CrearListaDesdeTextBox(string texto)
        {
            ListaSimple lista = new ListaSimple();

            // Dividir el texto usando "->", "," y espacios como separadores
            string[] valores = texto.Split(new string[] { "->", ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string valor in valores)
            {
                string trimmedValue = valor.Trim();

                // Ignorar específicamente el texto "null" y validar si el valor es un número entero
                if (trimmedValue.Equals("null", StringComparison.OrdinalIgnoreCase))
                {
                    continue; // Ignorar el texto "null"
                }

                if (int.TryParse(trimmedValue, out int _))
                {
                    lista.InsertarFinal(trimmedValue);
                }
                else
                {
                    // Solo mostrar advertencia si el valor no está vacío y no es "null"
                    if (!string.IsNullOrEmpty(trimmedValue))
                    {
                        MessageBox.Show($"El valor '{valor}' no es válido y será ignorado.",
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }

            return lista;
        }
        private void BtnOrdenarLista_Click(object sender, EventArgs e)
        {
            // Verificamos que haya datos en el cuadro de texto
            if (string.IsNullOrWhiteSpace(TxtLista.Text))
            {
                MessageBox.Show("Por favor ingresa una lista de valores separados por comas.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Convertimos el contenido de TxtLista a una ListaSimple
            ListaSimple lista = CrearListaDesdeTextBox(TxtLista.Text);

            if (lista.estaVacio())
            {
                MessageBox.Show("La lista está vacía o contiene elementos no válidos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Iniciar el cronómetro
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Llamamos al algoritmo Radix para ordenar la ListaSimple
            ShellSort.FuncionShellSort(lista);

            // Detener el cronómetro
            stopwatch.Stop();

            // Mostrar la lista ordenada en TxtListaOrdenada
            TxtListaOrdenada.Text = lista.ToString(); // ListaSimple debe implementar ToString correctamente

            // Mostrar el tiempo de ejecución
            txtTiempo.Text = $"{stopwatch.ElapsedTicks} ticks";
        }
    }
}
