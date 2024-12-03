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
    public partial class FrmFactorial : Form
    {
        public FrmFactorial()
        {
            InitializeComponent();
        }
        Factorial factorial = new Factorial();
        private void EntrarFactorial_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(CuadroTxtFact.Text, out n) && n >= 0)
            {
                // Calcular el factorial
                long resultado = factorial.fact(n);
                // Mostrar el resultado en el TextBox
                textBoxResultadoFact.Text = $"El factorial de {n} es: {resultado}\n";
                // Hacer visible el TextBox después de calcular el resultado
                textBoxResultadoFact.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero válido y no negativo.");
            }
        }
    }
}
