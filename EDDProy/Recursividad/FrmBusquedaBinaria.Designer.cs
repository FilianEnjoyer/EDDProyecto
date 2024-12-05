namespace EDDemo.Recursividad
{
    partial class FrmBusquedaBinaria
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
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ResultadoIndicesTxtBox = new System.Windows.Forms.TextBox();
            this.btBuscarEnArreglo = new System.Windows.Forms.Button();
            this.PedirNumeroBusquedaBinaria = new System.Windows.Forms.Label();
            this.PedirNumeroBusquedaTxtBox = new System.Windows.Forms.TextBox();
            this.ResultadoGenerarArregloTxtBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btGenerarArreglo = new System.Windows.Forms.Button();
            this.PedirElementosBusquedaBinaria = new System.Windows.Forms.Label();
            this.EscribirNumElementosBusquedaTxtBox = new System.Windows.Forms.TextBox();
            this.DescripcionBusquedaBinaria = new System.Windows.Forms.Label();
            this.TituloBusquedaBinaria = new System.Windows.Forms.Label();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 205);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(666, 21);
            this.label16.TabIndex = 44;
            this.label16.Text = "El algoritmo te dirá todos los índices en los que el número se encuentra, si hay " +
    "duplicados.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(523, 21);
            this.label15.TabIndex = 43;
            this.label15.Text = "Después, podrás introducir el número que deseas buscar en el arreglo.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(611, 21);
            this.label14.TabIndex = 42;
            this.label14.Text = "Llenará el arreglo con números aleatorios del 1 al 1000, y luego ordenará el arre" +
    "glo.";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(438, 21);
            this.label12.TabIndex = 41;
            this.label12.Text = "El algoritmo te pedirá el número de elementos del arreglo.";
            // 
            // ResultadoIndicesTxtBox
            // 
            this.ResultadoIndicesTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoIndicesTxtBox.Location = new System.Drawing.Point(445, 391);
            this.ResultadoIndicesTxtBox.Name = "ResultadoIndicesTxtBox";
            this.ResultadoIndicesTxtBox.Size = new System.Drawing.Size(332, 25);
            this.ResultadoIndicesTxtBox.TabIndex = 40;
            // 
            // btBuscarEnArreglo
            // 
            this.btBuscarEnArreglo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btBuscarEnArreglo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscarEnArreglo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarEnArreglo.Location = new System.Drawing.Point(518, 344);
            this.btBuscarEnArreglo.Name = "btBuscarEnArreglo";
            this.btBuscarEnArreglo.Size = new System.Drawing.Size(136, 34);
            this.btBuscarEnArreglo.TabIndex = 39;
            this.btBuscarEnArreglo.Text = "Buscar";
            this.btBuscarEnArreglo.UseVisualStyleBackColor = false;
            this.btBuscarEnArreglo.Click += new System.EventHandler(this.btBuscarEnArreglo_Click);
            // 
            // PedirNumeroBusquedaBinaria
            // 
            this.PedirNumeroBusquedaBinaria.AutoSize = true;
            this.PedirNumeroBusquedaBinaria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PedirNumeroBusquedaBinaria.Location = new System.Drawing.Point(443, 294);
            this.PedirNumeroBusquedaBinaria.Name = "PedirNumeroBusquedaBinaria";
            this.PedirNumeroBusquedaBinaria.Size = new System.Drawing.Size(301, 21);
            this.PedirNumeroBusquedaBinaria.TabIndex = 38;
            this.PedirNumeroBusquedaBinaria.Text = "Que numero del 1 al 1000 quieres buscar";
            // 
            // PedirNumeroBusquedaTxtBox
            // 
            this.PedirNumeroBusquedaTxtBox.Location = new System.Drawing.Point(518, 318);
            this.PedirNumeroBusquedaTxtBox.Name = "PedirNumeroBusquedaTxtBox";
            this.PedirNumeroBusquedaTxtBox.Size = new System.Drawing.Size(136, 20);
            this.PedirNumeroBusquedaTxtBox.TabIndex = 37;
            // 
            // ResultadoGenerarArregloTxtBox
            // 
            this.ResultadoGenerarArregloTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoGenerarArregloTxtBox.Location = new System.Drawing.Point(50, 391);
            this.ResultadoGenerarArregloTxtBox.Name = "ResultadoGenerarArregloTxtBox";
            this.ResultadoGenerarArregloTxtBox.Size = new System.Drawing.Size(336, 25);
            this.ResultadoGenerarArregloTxtBox.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(403, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 21);
            this.label13.TabIndex = 35;
            // 
            // btGenerarArreglo
            // 
            this.btGenerarArreglo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btGenerarArreglo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGenerarArreglo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerarArreglo.Location = new System.Drawing.Point(135, 344);
            this.btGenerarArreglo.Name = "btGenerarArreglo";
            this.btGenerarArreglo.Size = new System.Drawing.Size(136, 34);
            this.btGenerarArreglo.TabIndex = 34;
            this.btGenerarArreglo.Text = "Generar Arreglo";
            this.btGenerarArreglo.UseVisualStyleBackColor = false;
            this.btGenerarArreglo.Click += new System.EventHandler(this.btGenerarArreglo_Click);
            // 
            // PedirElementosBusquedaBinaria
            // 
            this.PedirElementosBusquedaBinaria.AutoSize = true;
            this.PedirElementosBusquedaBinaria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PedirElementosBusquedaBinaria.Location = new System.Drawing.Point(46, 294);
            this.PedirElementosBusquedaBinaria.Name = "PedirElementosBusquedaBinaria";
            this.PedirElementosBusquedaBinaria.Size = new System.Drawing.Size(318, 21);
            this.PedirElementosBusquedaBinaria.TabIndex = 33;
            this.PedirElementosBusquedaBinaria.Text = "Dame el numero de elementos del arreglo";
            // 
            // EscribirNumElementosBusquedaTxtBox
            // 
            this.EscribirNumElementosBusquedaTxtBox.Location = new System.Drawing.Point(135, 318);
            this.EscribirNumElementosBusquedaTxtBox.Name = "EscribirNumElementosBusquedaTxtBox";
            this.EscribirNumElementosBusquedaTxtBox.Size = new System.Drawing.Size(136, 20);
            this.EscribirNumElementosBusquedaTxtBox.TabIndex = 32;
            // 
            // DescripcionBusquedaBinaria
            // 
            this.DescripcionBusquedaBinaria.AutoSize = true;
            this.DescripcionBusquedaBinaria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionBusquedaBinaria.Location = new System.Drawing.Point(74, 99);
            this.DescripcionBusquedaBinaria.Name = "DescripcionBusquedaBinaria";
            this.DescripcionBusquedaBinaria.Size = new System.Drawing.Size(691, 25);
            this.DescripcionBusquedaBinaria.TabIndex = 31;
            this.DescripcionBusquedaBinaria.Text = "Este algortimo busca el numero que especifiques en un arreglo del tamaño dado";
            // 
            // TituloBusquedaBinaria
            // 
            this.TituloBusquedaBinaria.AutoSize = true;
            this.TituloBusquedaBinaria.BackColor = System.Drawing.SystemColors.Control;
            this.TituloBusquedaBinaria.Cursor = System.Windows.Forms.Cursors.Default;
            this.TituloBusquedaBinaria.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloBusquedaBinaria.Location = new System.Drawing.Point(267, 35);
            this.TituloBusquedaBinaria.Name = "TituloBusquedaBinaria";
            this.TituloBusquedaBinaria.Size = new System.Drawing.Size(281, 45);
            this.TituloBusquedaBinaria.TabIndex = 30;
            this.TituloBusquedaBinaria.Text = "Busqueda Binaria";
            // 
            // LblTiempo
            // 
            this.LblTiempo.AutoSize = true;
            this.LblTiempo.Location = new System.Drawing.Point(181, 425);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(42, 13);
            this.LblTiempo.TabIndex = 45;
            this.LblTiempo.Text = "Tiempo";
            // 
            // FrmBusquedaBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTiempo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ResultadoIndicesTxtBox);
            this.Controls.Add(this.btBuscarEnArreglo);
            this.Controls.Add(this.PedirNumeroBusquedaBinaria);
            this.Controls.Add(this.PedirNumeroBusquedaTxtBox);
            this.Controls.Add(this.ResultadoGenerarArregloTxtBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btGenerarArreglo);
            this.Controls.Add(this.PedirElementosBusquedaBinaria);
            this.Controls.Add(this.EscribirNumElementosBusquedaTxtBox);
            this.Controls.Add(this.DescripcionBusquedaBinaria);
            this.Controls.Add(this.TituloBusquedaBinaria);
            this.Name = "FrmBusquedaBinaria";
            this.Text = "FrmBusquedaBinaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ResultadoIndicesTxtBox;
        private System.Windows.Forms.Button btBuscarEnArreglo;
        private System.Windows.Forms.Label PedirNumeroBusquedaBinaria;
        private System.Windows.Forms.TextBox PedirNumeroBusquedaTxtBox;
        private System.Windows.Forms.TextBox ResultadoGenerarArregloTxtBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btGenerarArreglo;
        private System.Windows.Forms.Label PedirElementosBusquedaBinaria;
        private System.Windows.Forms.TextBox EscribirNumElementosBusquedaTxtBox;
        private System.Windows.Forms.Label DescripcionBusquedaBinaria;
        private System.Windows.Forms.Label TituloBusquedaBinaria;
        private System.Windows.Forms.Label LblTiempo;
    }
}