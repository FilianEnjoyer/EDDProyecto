using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HashNamespace;
using System.Collections;
using System.Diagnostics;

namespace EDDemo.Metodos_de_busqueda
{
    public partial class FrmHash : Form
    {
        private Hash tablaHash = new Hash();
        private const string archivoHash = "ClavesHash.txt";

        public FrmHash()
        {
            InitializeComponent();
        }

        private void BtnGenerarClave_Click(object sender, EventArgs e)
        {
            string producto = TxtProducto.Text.Trim();
            if (!string.IsNullOrEmpty(producto))
            {
                int clave = Hash.FuncionHashPolinomial(producto, 100); // Generar clave hash
                tablaHash.Insertar(clave, producto);

                // Guardar clave y producto en el archivo
                using (StreamWriter writer = new StreamWriter(archivoHash, true))
                {
                    writer.WriteLine($"{clave},{producto}");
                }

                // Mostrar en el TextBox
                TxtClaves.AppendText($"Clave: {clave} - Producto: {producto}\r\n");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un producto.");
            }
        }

        private void BtnBuscarClave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtClaveABuscar.Text.Trim(), out int clave))
            {
                // Iniciar el temporizador
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string resultado = tablaHash.Buscar(clave);
                if (resultado != null)
                {
                    TxtResultado.Text = $"Productos: {resultado.Replace(" -> null", "")}";
                }
                else
                {
                    TxtResultado.Text = "No se encontró ningún producto para esta clave.";
                }
                // Detener el temporizador
                stopwatch.Stop();

                // Mostrar el tiempo en ticks en el label
                LblTiempo.Text = $"Tiempo de búsqueda: {stopwatch.ElapsedTicks} ticks";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una clave válida.");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            tablaHash.VaciarTabla(); // Vaciar la tabla hash
            File.WriteAllText(archivoHash, string.Empty); // Limpiar el archivo
            TxtClaves.Clear(); // Limpiar el TextBox de claves
            TxtResultado.Clear(); // Limpiar el TextBox de resultados
            MessageBox.Show("Tabla hash y archivo limpiados.");
        }
    }
}
