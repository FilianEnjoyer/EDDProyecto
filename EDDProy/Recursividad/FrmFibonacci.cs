using EDDemo.Recursividad.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Recursividad
{
    public partial class FrmFibonacci : Form
    {
        Fibonacci fibonacci = new Fibonacci();
        public FrmFibonacci()
        {
            InitializeComponent();
        }

        private void btEnterFib_Click(object sender, EventArgs e)
        {
            int n;
            // Asegúrate de que el valor ingresado sea numérico
            if (int.TryParse(txtboxEscribirFib.Text, out n) && n >= 0)
            {
                // Obtener la secuencia de Fibonacci
                string resultadoFibonacci = fibonacci.ObtenerFibonacci(n);
                // Mostrar el resultado en el TextBox
                textBoxResultadoFib.Text = $"La secuencia de Fibonacci hasta {n} es: {resultadoFibonacci}\n";

                // Hacer visible el TextBox con el resultado
                textBoxResultadoFib.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero válido y no negativo.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResultadoFib_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPedirNumFib_Click(object sender, EventArgs e)
        {

        }

        private void txtboxEscribirFib_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDescripcionFib_Click(object sender, EventArgs e)
        {

        }

        private void TituloFibonacci_Click(object sender, EventArgs e)
        {

        }
    }
}
