using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections;
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
    public partial class FrmListasSimples : Form
    {
        ListaSimple lista = new ListaSimple();
        public FrmListasSimples()
        {
            InitializeComponent();
        }
        // Método para actualizar y mostrar la lista en el TextBox de resultados
        private void ActualizarLista()
        {
            var (recorrido, _) = lista.Recorrer();
            TxResultado.Text = recorrido;  // Mostrar el contenido de la lista en el TextBox de resultados
        }

        // Método para mostrar el tiempo y operaciones en el TextBox de información
        private void MostrarTiempoYOperaciones(Stopwatch stopwatch, int operaciones)
        {
            long tiempoMs = stopwatch.ElapsedMilliseconds;
            long tiempoTicks = stopwatch.ElapsedTicks;
            TxInfo.Text = $"Tiempo: {tiempoMs} ms, {tiempoTicks} ticks, Operaciones: {operaciones}";
        }
        private void BtInsetarInicio_Click(object sender, EventArgs e)
        {
            string valor = TxInPut.Text;
            if (!string.IsNullOrEmpty(valor))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                int operaciones = lista.InsertarInicio(valor);  // Insertar al inicio
                stopwatch.Stop();

                MostrarTiempoYOperaciones(stopwatch, operaciones);
                ActualizarLista();
                TxInPut.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor.");
            }
        }

        private void BtInsetarFinal_Click(object sender, EventArgs e)
        {
            string valor = TxInPut.Text;
            if (!string.IsNullOrEmpty(valor))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                int operaciones = lista.InsertarFinal(valor);  // Insertar al final
                stopwatch.Stop();

                MostrarTiempoYOperaciones(stopwatch, operaciones);
                ActualizarLista();
                TxInPut.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor.");
            }
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            string valor = TxInPut.Text;
            if (!string.IsNullOrEmpty(valor))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                var (posicion, operaciones) = lista.Buscar(valor);  // Buscar el valor
                stopwatch.Stop();

                if (posicion >= 0)
                {
                    MessageBox.Show($"El valor {valor} se encuentra en la posición {posicion}.");
                }
                else
                {
                    MessageBox.Show($"El valor {valor} no se encontró en la lista.");
                }

                MostrarTiempoYOperaciones(stopwatch, operaciones);
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.");
            }

        }

        private void BtEliminarDato_Click(object sender, EventArgs e)
        {
            string valor = TxInPut.Text;
            if (!string.IsNullOrEmpty(valor))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                int operaciones = lista.EliminarValor(valor);  // Eliminar el valor
                stopwatch.Stop();

                MostrarTiempoYOperaciones(stopwatch, operaciones);
                ActualizarLista();
                TxInPut.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor para eliminar.");
            }
        }

        private void BtInsetarPosicion_Click(object sender, EventArgs e)
        {
            string valor = TxInPut.Text;
            if (int.TryParse(TxPosicion.Text, out int posicion) && !string.IsNullOrEmpty(valor))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                int operaciones = lista.InsertarPos(valor, posicion);  // Insertar en posición
                stopwatch.Stop();

                MostrarTiempoYOperaciones(stopwatch, operaciones);
                ActualizarLista();
                TxInPut.Clear();
                TxPosicion.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor y una posición válida.");
            }
        }

        private void BtListaVaciar_Click(object sender, EventArgs e)
        {
            while (!lista.estaVacio())
            {
                lista.EliminarTop();
            }
            ActualizarLista();
            MessageBox.Show("La lista ha sido vaciada");
        }
    }
}
