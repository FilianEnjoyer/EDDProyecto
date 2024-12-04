namespace EDDemo.Metodos_de_Ordenamiento
{
    partial class FrmMezclaNatural
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
            this.TxtTiempo = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtListaOrdenada = new System.Windows.Forms.TextBox();
            this.BtnGenerarLista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLista = new System.Windows.Forms.TextBox();
            this.TxtNumeroElementos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 78;
            this.label1.Text = "MEZCLA NATURAL";
            // 
            // TxtTiempo
            // 
            this.TxtTiempo.Location = new System.Drawing.Point(412, 403);
            this.TxtTiempo.Name = "TxtTiempo";
            this.TxtTiempo.ReadOnly = true;
            this.TxtTiempo.Size = new System.Drawing.Size(78, 20);
            this.TxtTiempo.TabIndex = 77;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(412, 129);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(360, 20);
            this.btnOrdenar.TabIndex = 76;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(530, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 75;
            this.label6.Text = "Lista ordenada";
            // 
            // TxtListaOrdenada
            // 
            this.TxtListaOrdenada.Location = new System.Drawing.Point(412, 179);
            this.TxtListaOrdenada.Multiline = true;
            this.TxtListaOrdenada.Name = "TxtListaOrdenada";
            this.TxtListaOrdenada.Size = new System.Drawing.Size(360, 212);
            this.TxtListaOrdenada.TabIndex = 74;
            // 
            // BtnGenerarLista
            // 
            this.BtnGenerarLista.Location = new System.Drawing.Point(28, 182);
            this.BtnGenerarLista.Name = "BtnGenerarLista";
            this.BtnGenerarLista.Size = new System.Drawing.Size(290, 20);
            this.BtnGenerarLista.TabIndex = 73;
            this.BtnGenerarLista.Text = "Generar lista";
            this.BtnGenerarLista.UseVisualStyleBackColor = true;
            this.BtnGenerarLista.Click += new System.EventHandler(this.BtnGenerarLista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(65, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 72;
            this.label3.Text = "Numero de elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(150, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 71;
            this.label2.Text = "Lista";
            // 
            // TxtLista
            // 
            this.TxtLista.Location = new System.Drawing.Point(28, 232);
            this.TxtLista.Multiline = true;
            this.TxtLista.Name = "TxtLista";
            this.TxtLista.Size = new System.Drawing.Size(290, 159);
            this.TxtLista.TabIndex = 70;
            // 
            // TxtNumeroElementos
            // 
            this.TxtNumeroElementos.Location = new System.Drawing.Point(28, 156);
            this.TxtNumeroElementos.Name = "TxtNumeroElementos";
            this.TxtNumeroElementos.Size = new System.Drawing.Size(290, 20);
            this.TxtNumeroElementos.TabIndex = 69;
            // 
            // FrmMezclaNatural
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTiempo);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtListaOrdenada);
            this.Controls.Add(this.BtnGenerarLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLista);
            this.Controls.Add(this.TxtNumeroElementos);
            this.Name = "FrmMezclaNatural";
            this.Text = "FrmMezclaNatural";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTiempo;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtListaOrdenada;
        private System.Windows.Forms.Button BtnGenerarLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLista;
        private System.Windows.Forms.TextBox TxtNumeroElementos;
    }
}