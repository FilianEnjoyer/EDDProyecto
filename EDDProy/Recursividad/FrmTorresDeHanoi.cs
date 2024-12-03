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
    public partial class FrmTorresDeHanoi : Form
    {
        TorresDeHanoi hanoi = new TorresDeHanoi();
        public FrmTorresDeHanoi()
        {
            InitializeComponent();
        }

        private void btEjecutarHanoi_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(LeerDiscosTxtBox.Text, out n) && n >= 1)
            {
                // Usar StringBuilder para acumular el resultado
                StringBuilder resultado = new StringBuilder();
                // Ejecutar el algoritmo de Torres de Hanoi
                hanoi.MoverDiscos(n, 'A', 'C', 'B', resultado);
                // Mostrar el resultado en el TextBox
                ResultadoHanoiTxtBox.Text = resultado.ToString();

                // Hacer visible el TextBox con el resultado
                ResultadoHanoiTxtBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero válido y mayor o igual a 1.");
            }
        }
    }
}
