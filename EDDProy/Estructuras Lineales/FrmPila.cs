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
    public partial class FrmPila : Form
    {
        Pilas pila = new Pilas();
        public FrmPila()
        {
            InitializeComponent();
        }
        private void ActualizarPila()
        {
            var (recorrido, _) = pila.Recorrer();
            TxResultado.Text = recorrido;  // Mostrar el contenido de la pila en el TextBox de resultados
        }

        // Método para mostrar el tiempo y operaciones en el TextBox de información
        private void MostrarTiempoYOperaciones(Stopwatch stopwatch, int operaciones)
        {
            long tiempoMs = stopwatch.ElapsedMilliseconds;
            long tiempoTicks = stopwatch.ElapsedTicks;
            TxInfo.Text = $"Tiempo: {tiempoMs} ms, {tiempoTicks} ticks, Operaciones: {operaciones}";
        }

        private void BtAñadir_Click(object sender, EventArgs e)
        {
            string dato = TxInPut.Text;  // Obtener el dato del TextBox
            if (!string.IsNullOrEmpty(dato))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                int operaciones = pila.Push(dato);  // Añadir el dato a la pila
                stopwatch.Stop();

                MostrarTiempoYOperaciones(stopwatch, operaciones);
                ActualizarPila();  // Mostrar la pila actualizada en el TextBox de resultados
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
                var (posicion, operaciones) = pila.Buscar(valor);
                stopwatch.Stop();

                if (posicion >= 0)
                {
                    MessageBox.Show("El dato " + valor + " está en la posición " + posicion);
                }
                else
                {
                    MessageBox.Show("El dato " + valor + " no se encontró en la pila.");
                }

                MostrarTiempoYOperaciones(stopwatch, operaciones);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.");
            }
            ActualizarPila();  // Mostrar la pila actualizada en el TextBox de resultados
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var (eliminado, operaciones) = pila.Pop();
            stopwatch.Stop();

            MessageBox.Show("Elemento eliminado: " + eliminado);
            MostrarTiempoYOperaciones(stopwatch, operaciones);
            ActualizarPila();  // Mostrar la pila actualizada en el TextBox de resultados
        }

        private void BtPilaVaciar_Click(object sender, EventArgs e)
        {
            pila.Vaciar();
            ActualizarPila();
        }
    }
}
