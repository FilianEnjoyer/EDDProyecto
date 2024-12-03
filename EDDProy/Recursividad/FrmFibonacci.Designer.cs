namespace EDDemo.Recursividad
{
    partial class FrmFibonacci
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
            this.textBoxResultadoFib = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btEnterFib = new System.Windows.Forms.Button();
            this.labelPedirNumFib = new System.Windows.Forms.Label();
            this.txtboxEscribirFib = new System.Windows.Forms.TextBox();
            this.labelDescripcionFib = new System.Windows.Forms.Label();
            this.TituloFibonacci = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxResultadoFib
            // 
            this.textBoxResultadoFib.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultadoFib.Location = new System.Drawing.Point(35, 319);
            this.textBoxResultadoFib.Name = "textBoxResultadoFib";
            this.textBoxResultadoFib.Size = new System.Drawing.Size(730, 25);
            this.textBoxResultadoFib.TabIndex = 20;
            this.textBoxResultadoFib.TextChanged += new System.EventHandler(this.textBoxResultadoFib_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 19;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btEnterFib
            // 
            this.btEnterFib.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btEnterFib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnterFib.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnterFib.Location = new System.Drawing.Point(351, 272);
            this.btEnterFib.Name = "btEnterFib";
            this.btEnterFib.Size = new System.Drawing.Size(75, 34);
            this.btEnterFib.TabIndex = 18;
            this.btEnterFib.Text = "Ejecutar";
            this.btEnterFib.UseVisualStyleBackColor = false;
            this.btEnterFib.Click += new System.EventHandler(this.btEnterFib_Click);
            // 
            // labelPedirNumFib
            // 
            this.labelPedirNumFib.AutoSize = true;
            this.labelPedirNumFib.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedirNumFib.Location = new System.Drawing.Point(321, 222);
            this.labelPedirNumFib.Name = "labelPedirNumFib";
            this.labelPedirNumFib.Size = new System.Drawing.Size(135, 21);
            this.labelPedirNumFib.TabIndex = 17;
            this.labelPedirNumFib.Text = "Dame un numero";
            this.labelPedirNumFib.Click += new System.EventHandler(this.labelPedirNumFib_Click);
            // 
            // txtboxEscribirFib
            // 
            this.txtboxEscribirFib.Location = new System.Drawing.Point(320, 246);
            this.txtboxEscribirFib.Name = "txtboxEscribirFib";
            this.txtboxEscribirFib.Size = new System.Drawing.Size(136, 20);
            this.txtboxEscribirFib.TabIndex = 16;
            this.txtboxEscribirFib.TextChanged += new System.EventHandler(this.txtboxEscribirFib_TextChanged);
            // 
            // labelDescripcionFib
            // 
            this.labelDescripcionFib.AutoSize = true;
            this.labelDescripcionFib.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionFib.Location = new System.Drawing.Point(54, 173);
            this.labelDescripcionFib.Name = "labelDescripcionFib";
            this.labelDescripcionFib.Size = new System.Drawing.Size(674, 25);
            this.labelDescripcionFib.TabIndex = 15;
            this.labelDescripcionFib.Text = "Este algortimo te da la secuencia de Fibonacci hasta el numero que le indiques";
            this.labelDescripcionFib.Click += new System.EventHandler(this.labelDescripcionFib_Click);
            // 
            // TituloFibonacci
            // 
            this.TituloFibonacci.AutoSize = true;
            this.TituloFibonacci.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFibonacci.Location = new System.Drawing.Point(220, 107);
            this.TituloFibonacci.Name = "TituloFibonacci";
            this.TituloFibonacci.Size = new System.Drawing.Size(362, 45);
            this.TituloFibonacci.TabIndex = 14;
            this.TituloFibonacci.Text = "Secuencia de Fibonacci";
            this.TituloFibonacci.Click += new System.EventHandler(this.TituloFibonacci_Click);
            // 
            // FrmFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResultadoFib);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btEnterFib);
            this.Controls.Add(this.labelPedirNumFib);
            this.Controls.Add(this.txtboxEscribirFib);
            this.Controls.Add(this.labelDescripcionFib);
            this.Controls.Add(this.TituloFibonacci);
            this.Name = "FrmFibonacci";
            this.Text = "FrmFibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResultadoFib;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEnterFib;
        private System.Windows.Forms.Label labelPedirNumFib;
        private System.Windows.Forms.TextBox txtboxEscribirFib;
        private System.Windows.Forms.Label labelDescripcionFib;
        private System.Windows.Forms.Label TituloFibonacci;
    }
}