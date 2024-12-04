namespace EDDemo.Metodos_de_Ordenamiento
{
    partial class FrmBurbuja
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.btnOrdenarLista = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtListaOrdenada = new System.Windows.Forms.TextBox();
            this.btnGenerarLista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.txtInPut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 29);
            this.label1.TabIndex = 67;
            this.label1.Text = "ORDENAMIENTO DE BURBUJA";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(452, 340);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(78, 20);
            this.txtTiempo.TabIndex = 66;
            // 
            // btnOrdenarLista
            // 
            this.btnOrdenarLista.Location = new System.Drawing.Point(200, 157);
            this.btnOrdenarLista.Name = "btnOrdenarLista";
            this.btnOrdenarLista.Size = new System.Drawing.Size(178, 20);
            this.btnOrdenarLista.TabIndex = 65;
            this.btnOrdenarLista.Text = "Ordenar";
            this.btnOrdenarLista.UseVisualStyleBackColor = true;
            this.btnOrdenarLista.Click += new System.EventHandler(this.btnOrdenarLista_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(558, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 64;
            this.label6.Text = "Lista ordenada";
            // 
            // txtListaOrdenada
            // 
            this.txtListaOrdenada.Location = new System.Drawing.Point(452, 131);
            this.txtListaOrdenada.Multiline = true;
            this.txtListaOrdenada.Name = "txtListaOrdenada";
            this.txtListaOrdenada.Size = new System.Drawing.Size(330, 164);
            this.txtListaOrdenada.TabIndex = 63;
            // 
            // btnGenerarLista
            // 
            this.btnGenerarLista.Location = new System.Drawing.Point(18, 157);
            this.btnGenerarLista.Name = "btnGenerarLista";
            this.btnGenerarLista.Size = new System.Drawing.Size(176, 20);
            this.btnGenerarLista.TabIndex = 62;
            this.btnGenerarLista.Text = "Generar";
            this.btnGenerarLista.UseVisualStyleBackColor = true;
            this.btnGenerarLista.Click += new System.EventHandler(this.btnGenerarLista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(105, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "Elementos de la lista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(162, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "LISTA";
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(18, 224);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(360, 199);
            this.txtLista.TabIndex = 59;
            // 
            // txtInPut
            // 
            this.txtInPut.Location = new System.Drawing.Point(18, 131);
            this.txtInPut.Name = "txtInPut";
            this.txtInPut.Size = new System.Drawing.Size(360, 20);
            this.txtInPut.TabIndex = 58;
            // 
            // FrmBurbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.btnOrdenarLista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtListaOrdenada);
            this.Controls.Add(this.btnGenerarLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.txtInPut);
            this.Name = "FrmBurbuja";
            this.Text = "FrmBurbuja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Button btnOrdenarLista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtListaOrdenada;
        private System.Windows.Forms.Button btnGenerarLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.TextBox txtInPut;
    }
}