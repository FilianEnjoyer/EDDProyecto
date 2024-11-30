using EDDemo.Estructuras_Lineales.Clases;
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

namespace EDDemo.Estructuras_Lineales
{
    public partial class FrmCola : Form
    {
        Cola cola = new Cola();  // Instancia de la cola
        public FrmCola()
        {
            InitializeComponent();
        }
        private void ActualizarCola()
        {
            var (recorrido, _) = cola.Recorrer();
            TxResultado.Text = recorrido;  // Mostrar el contenido de la cola en el TextBox de resultados
        }
        private void MostrarTiempoYOperaciones(Stopwatch stopwatch, int operaciones)
        {
            long tiempoMs = stopwatch.ElapsedMilliseconds;
            long tiempoTicks = stopwatch.ElapsedTicks;
            TxInfo.Text = $"Tiempo: {tiempoMs} ms, {tiempoTicks} ticks, Operaciones: {operaciones}";
        }
        private void BtQueue_Click(object sender, EventArgs e)
        {
            string dato = TxInPut.Text;  // Obtener el dato del TextBox
            if (!string.IsNullOrEmpty(dato))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                int operaciones = cola.Queue(dato);  // Encolar el dato
                stopwatch.Stop();

                MostrarTiempoYOperaciones(stopwatch, operaciones);
                ActualizarCola();  // Mostrar la cola actualizada
                TxInPut.Clear();  // Limpiar el TextBox
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor.");
            }
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            string valor = TxInPut.Text;  // Usar el mismo TextBox para buscar
            if (!string.IsNullOrEmpty(valor))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                var (posicion, operaciones) = cola.Buscar(valor);
                stopwatch.Stop();

                if (posicion >= 0)
                {
                    MessageBox.Show("El dato " + valor + " está en la posición " + posicion);
                }
                else
                {
                    MessageBox.Show("El dato " + valor + " no se encontró en la cola.");
                }

                MostrarTiempoYOperaciones(stopwatch, operaciones);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.");
            }
            ActualizarCola();  // Mostrar la cola actualizada
        }

        private void BtDequeue_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var (eliminado, operaciones) = cola.Dequeue();
            stopwatch.Stop();

            MessageBox.Show("Elemento desencolado: " + eliminado);
            MostrarTiempoYOperaciones(stopwatch, operaciones);
            ActualizarCola();  // Mostrar la cola actualizada
        }

        private void BtColaVaciar_Click(object sender, EventArgs e)
        {
            cola.Vaciar();
            ActualizarCola();

        }
    }
}
