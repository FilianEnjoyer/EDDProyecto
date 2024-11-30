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
    }
}
