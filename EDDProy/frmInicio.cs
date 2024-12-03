using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Recursividad;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPila mPila = new FrmPila();
            mPila.MdiParent = this;
            mPila.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCola mCola = new FrmCola();
            mCola.MdiParent = this;
            mCola.Show();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListasSimples mListaS = new FrmListasSimples();
            mListaS.MdiParent = this;
            mListaS.Show();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListasDobles mListaD = new FrmListasDobles();
            mListaD.MdiParent = this;
            mListaD.Show();
        }

        private void listaCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListasCirculares mListaC = new FrmListasCirculares();
            mListaC.MdiParent = this;
            mListaC.Show();
        }

        private void listaCircularDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListasCircularesDobles mListaCD = new FrmListasCircularesDobles();
            mListaCD.MdiParent = this;
            mListaCD.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFactorial mFactorial = new FrmFactorial();
            mFactorial.MdiParent = this;
            mFactorial.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFibonacci mFibonacci = new FrmFibonacci();
            mFibonacci.MdiParent = this;
            mFibonacci.Show();
        }

        private void potenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPotencia mPotencia = new FrmPotencia();
            mPotencia.MdiParent = this;
            mPotencia.Show();
        }

        private void sumarArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSumarArreglos mSumarArreglos = new FrmSumarArreglos();
            mSumarArreglos.MdiParent = this;
            mSumarArreglos.Show();
        }
    }
}
