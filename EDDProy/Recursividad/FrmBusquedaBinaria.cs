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
    public partial class FrmBusquedaBinaria : Form
    {
        BusquedaBinaria bbinaria = new BusquedaBinaria();
        private int[] arreglo;
        public FrmBusquedaBinaria()
        {
            InitializeComponent();
        }

        private void btGenerarArreglo_Click(object sender, EventArgs e)
        {
            int numElementos;
            if (int.TryParse(EscribirNumElementosBusquedaTxtBox.Text, out numElementos) && numElementos > 0)
            {
                // Generar y ordenar el arreglo
                arreglo = bbinaria.GenerarArregloAleatorio(numElementos);
                Array.Sort(arreglo);

                // Mostrar el arreglo ordenado
                ResultadoGenerarArregloTxtBox.Text = "Arreglo ordenado: \n" + string.Join(" ", arreglo);
                ResultadoGenerarArregloTxtBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero positivo.");
            }
        }

        private void btBuscarEnArreglo_Click(object sender, EventArgs e)
        {
            if (arreglo == null || arreglo.Length == 0) // Validar que el arreglo esté inicializado
            {
                MessageBox.Show("Por favor, genera un arreglo antes de realizar la búsqueda.");
                return;
            }
            int numeroBuscado;
            if (int.TryParse(PedirNumeroBusquedaTxtBox.Text, out numeroBuscado))
            {
                // Llamada a la función recursiva para buscar el número
                List<int> indices = bbinaria.BuscarTodosIndices(arreglo, numeroBuscado, 0, arreglo.Length - 1);
                // Mostrar el resultado
                if (indices.Count == 0)
                {
                    ResultadoIndicesTxtBox.Text = "Número no encontrado en el arreglo.";
                }
                else
                {
                    ResultadoIndicesTxtBox.Text = $"Número encontrado en los índices: \n" + string.Join("  ", indices);
                }

                ResultadoIndicesTxtBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero válido.");
            }
        }
    }
}
