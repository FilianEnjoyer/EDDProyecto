namespace EDDemo.Metodos_de_Ordenamiento
{
    partial class FrmIntercalacion
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
            this.BtnIntercalarArchivos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtArchivoIntercalado = new System.Windows.Forms.TextBox();
            this.BtnGenerarArchivo2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtArchivo2 = new System.Windows.Forms.TextBox();
            this.TxtNumElementosArchivo2 = new System.Windows.Forms.TextBox();
            this.BtnGenerarArchivo1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtArchivo1 = new System.Windows.Forms.TextBox();
            this.TxtNumElementosArchivo1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 62;
            this.label1.Text = "INTERCALACION";
            // 
            // TxtTiempo
            // 
            this.TxtTiempo.Location = new System.Drawing.Point(417, 400);
            this.TxtTiempo.Name = "TxtTiempo";
            this.TxtTiempo.ReadOnly = true;
            this.TxtTiempo.Size = new System.Drawing.Size(78, 20);
            this.TxtTiempo.TabIndex = 61;
            // 
            // BtnIntercalarArchivos
            // 
            this.BtnIntercalarArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIntercalarArchivos.Location = new System.Drawing.Point(417, 132);
            this.BtnIntercalarArchivos.Name = "BtnIntercalarArchivos";
            this.BtnIntercalarArchivos.Size = new System.Drawing.Size(348, 20);
            this.BtnIntercalarArchivos.TabIndex = 60;
            this.BtnIntercalarArchivos.Text = "Intercalar Archivos";
            this.BtnIntercalarArchivos.UseVisualStyleBackColor = true;
            this.BtnIntercalarArchivos.Click += new System.EventHandler(this.BtnIntercalarArchivos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(507, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "Archivo intercalado";
            // 
            // TxtArchivoIntercalado
            // 
            this.TxtArchivoIntercalado.Location = new System.Drawing.Point(417, 181);
            this.TxtArchivoIntercalado.Multiline = true;
            this.TxtArchivoIntercalado.Name = "TxtArchivoIntercalado";
            this.TxtArchivoIntercalado.Size = new System.Drawing.Size(360, 179);
            this.TxtArchivoIntercalado.TabIndex = 58;
            // 
            // BtnGenerarArchivo2
            // 
            this.BtnGenerarArchivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarArchivo2.Location = new System.Drawing.Point(23, 340);
            this.BtnGenerarArchivo2.Name = "BtnGenerarArchivo2";
            this.BtnGenerarArchivo2.Size = new System.Drawing.Size(360, 20);
            this.BtnGenerarArchivo2.TabIndex = 57;
            this.BtnGenerarArchivo2.Text = "Generar";
            this.BtnGenerarArchivo2.UseVisualStyleBackColor = true;
            this.BtnGenerarArchivo2.Click += new System.EventHandler(this.BtnGenerarArchivo2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(109, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Numero de Elementos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(158, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "Archivo 2";
            // 
            // TxtArchivo2
            // 
            this.TxtArchivo2.Location = new System.Drawing.Point(23, 366);
            this.TxtArchivo2.Multiline = true;
            this.TxtArchivo2.Name = "TxtArchivo2";
            this.TxtArchivo2.Size = new System.Drawing.Size(360, 74);
            this.TxtArchivo2.TabIndex = 54;
            // 
            // TxtNumElementosArchivo2
            // 
            this.TxtNumElementosArchivo2.Location = new System.Drawing.Point(23, 314);
            this.TxtNumElementosArchivo2.Name = "TxtNumElementosArchivo2";
            this.TxtNumElementosArchivo2.Size = new System.Drawing.Size(360, 20);
            this.TxtNumElementosArchivo2.TabIndex = 53;
            // 
            // BtnGenerarArchivo1
            // 
            this.BtnGenerarArchivo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarArchivo1.Location = new System.Drawing.Point(23, 158);
            this.BtnGenerarArchivo1.Name = "BtnGenerarArchivo1";
            this.BtnGenerarArchivo1.Size = new System.Drawing.Size(360, 20);
            this.BtnGenerarArchivo1.TabIndex = 52;
            this.BtnGenerarArchivo1.Text = "Generar";
            this.BtnGenerarArchivo1.UseVisualStyleBackColor = true;
            this.BtnGenerarArchivo1.Click += new System.EventHandler(this.BtnGenerarArchivo1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(109, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Numero de Elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(158, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Archivo 1";
            // 
            // TxtArchivo1
            // 
            this.TxtArchivo1.Location = new System.Drawing.Point(23, 184);
            this.TxtArchivo1.Multiline = true;
            this.TxtArchivo1.Name = "TxtArchivo1";
            this.TxtArchivo1.Size = new System.Drawing.Size(360, 69);
            this.TxtArchivo1.TabIndex = 49;
            // 
            // TxtNumElementosArchivo1
            // 
            this.TxtNumElementosArchivo1.Location = new System.Drawing.Point(23, 132);
            this.TxtNumElementosArchivo1.Name = "TxtNumElementosArchivo1";
            this.TxtNumElementosArchivo1.Size = new System.Drawing.Size(360, 20);
            this.TxtNumElementosArchivo1.TabIndex = 48;
            // 
            // FrmIntercalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTiempo);
            this.Controls.Add(this.BtnIntercalarArchivos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtArchivoIntercalado);
            this.Controls.Add(this.BtnGenerarArchivo2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtArchivo2);
            this.Controls.Add(this.TxtNumElementosArchivo2);
            this.Controls.Add(this.BtnGenerarArchivo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtArchivo1);
            this.Controls.Add(this.TxtNumElementosArchivo1);
            this.Name = "FrmIntercalacion";
            this.Text = "FrmIntercalacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTiempo;
        private System.Windows.Forms.Button BtnIntercalarArchivos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtArchivoIntercalado;
        private System.Windows.Forms.Button BtnGenerarArchivo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtArchivo2;
        private System.Windows.Forms.TextBox TxtNumElementosArchivo2;
        private System.Windows.Forms.Button BtnGenerarArchivo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtArchivo1;
        private System.Windows.Forms.TextBox TxtNumElementosArchivo1;
    }
}