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
    public partial class FrmSumarArreglos : Form
    {
        SumarArreglos arreglos = new SumarArreglos();
        public FrmSumarArreglos()
        {
            InitializeComponent();
        }

        private void btEntrarArreglo_Click(object sender, EventArgs e)
        {
            string[] input = txtboxArregloEscribir.Text.Split(',');
            int[] arreglo = new int[input.Length];

            // Convertir los elementos del arreglo de string a int
            for (int i = 0; i < input.Length; i++)
            {
                if (!int.TryParse(input[i].Trim(), out arreglo[i]))
                {
                    MessageBox.Show("Por favor, ingresa solo números enteros separados por comas.");
                    return;
                }
            }
            int suma = arreglos.Sumar(arreglo);
            // Mostrar el arreglo y el resultado en el TextBox
            StringBuilder sb = new StringBuilder();
            sb.Append("Arreglo: ");
            foreach (var item in arreglo)
            {
                sb.Append(item + " ");
            }
            sb.Append($"\nSuma de los elementos: {suma}\n");
            ResultadoArregloTxtBox.Text = sb.ToString();
            // Hacer visible el TextBox con el resultado
            ResultadoArregloTxtBox.Visible = true;
        }
    }
}
