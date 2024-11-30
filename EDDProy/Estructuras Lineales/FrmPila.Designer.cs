namespace EDDemo.Estructuras_Lineales
{
    partial class FrmPila
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.TxInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.TxInPut = new System.Windows.Forms.TextBox();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtAñadir = new System.Windows.Forms.Button();
            this.TxResultado = new System.Windows.Forms.TextBox();
            this.BtPilaVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Informacion";
            // 
            // TxInfo
            // 
            this.TxInfo.Location = new System.Drawing.Point(46, 371);
            this.TxInfo.Multiline = true;
            this.TxInfo.Name = "TxInfo";
            this.TxInfo.Size = new System.Drawing.Size(326, 44);
            this.TxInfo.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Escriba un dato";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(556, 36);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(61, 25);
            this.Titulo.TabIndex = 27;
            this.Titulo.Text = "PILA";
            // 
            // TxInPut
            // 
            this.TxInPut.Location = new System.Drawing.Point(46, 174);
            this.TxInPut.Name = "TxInPut";
            this.TxInPut.Size = new System.Drawing.Size(326, 20);
            this.TxInPut.TabIndex = 26;
            // 
            // BtEliminar
            // 
            this.BtEliminar.Location = new System.Drawing.Point(297, 230);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtEliminar.TabIndex = 25;
            this.BtEliminar.Text = "Pop";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(174, 230);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtBuscar.TabIndex = 24;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtAñadir
            // 
            this.BtAñadir.Location = new System.Drawing.Point(46, 230);
            this.BtAñadir.Name = "BtAñadir";
            this.BtAñadir.Size = new System.Drawing.Size(75, 23);
            this.BtAñadir.TabIndex = 23;
            this.BtAñadir.Text = "Push";
            this.BtAñadir.UseVisualStyleBackColor = true;
            this.BtAñadir.Click += new System.EventHandler(this.BtAñadir_Click);
            // 
            // TxResultado
            // 
            this.TxResultado.Location = new System.Drawing.Point(392, 66);
            this.TxResultado.Multiline = true;
            this.TxResultado.Name = "TxResultado";
            this.TxResultado.Size = new System.Drawing.Size(385, 349);
            this.TxResultado.TabIndex = 22;
            // 
            // BtPilaVaciar
            // 
            this.BtPilaVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPilaVaciar.Location = new System.Drawing.Point(24, 36);
            this.BtPilaVaciar.Name = "BtPilaVaciar";
            this.BtPilaVaciar.Size = new System.Drawing.Size(97, 48);
            this.BtPilaVaciar.TabIndex = 21;
            this.BtPilaVaciar.Text = "Vaciar";
            this.BtPilaVaciar.UseVisualStyleBackColor = true;
            this.BtPilaVaciar.Click += new System.EventHandler(this.BtPilaVaciar_Click);
            // 
            // FrmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.TxInPut);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.BtAñadir);
            this.Controls.Add(this.TxResultado);
            this.Controls.Add(this.BtPilaVaciar);
            this.Name = "FrmPila";
            this.Text = "FrmPila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TxInPut;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtAñadir;
        private System.Windows.Forms.TextBox TxResultado;
        private System.Windows.Forms.Button BtPilaVaciar;
    }
}