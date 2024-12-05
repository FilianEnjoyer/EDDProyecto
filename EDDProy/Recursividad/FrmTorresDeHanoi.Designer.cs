namespace EDDemo.Recursividad
{
    partial class FrmTorresDeHanoi
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ReglasHanoi1 = new System.Windows.Forms.Label();
            this.ResultadoHanoiTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btEjecutarHanoi = new System.Windows.Forms.Button();
            this.labelPedirDiscos = new System.Windows.Forms.Label();
            this.LeerDiscosTxtBox = new System.Windows.Forms.TextBox();
            this.DescripcionHanoi = new System.Windows.Forms.Label();
            this.TituloHanoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(507, 21);
            this.label11.TabIndex = 38;
            this.label11.Text = "5. Un disco no puede colocarse encima de un disco más pequeño.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 21);
            this.label10.TabIndex = 37;
            this.label10.Text = "4. Solo se puede mover un disco a la vez.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(738, 21);
            this.label9.TabIndex = 36;
            this.label9.Text = "3. El objetivo es mover todos los discos de la torre A a la torre C, usando la to" +
    "rre B como auxiliar.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(711, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "2. Hay varios discos de diferentes tamaños que se apilan en la torre A en orden d" +
    "escendente.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "1. Hay tres torres: A, B y C.";
            // 
            // ReglasHanoi1
            // 
            this.ReglasHanoi1.AutoSize = true;
            this.ReglasHanoi1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReglasHanoi1.Location = new System.Drawing.Point(31, 134);
            this.ReglasHanoi1.Name = "ReglasHanoi1";
            this.ReglasHanoi1.Size = new System.Drawing.Size(233, 21);
            this.ReglasHanoi1.TabIndex = 33;
            this.ReglasHanoi1.Text = "Reglas de las torres de Hanoi:";
            // 
            // ResultadoHanoiTxtBox
            // 
            this.ResultadoHanoiTxtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoHanoiTxtBox.Location = new System.Drawing.Point(56, 363);
            this.ResultadoHanoiTxtBox.Multiline = true;
            this.ResultadoHanoiTxtBox.Name = "ResultadoHanoiTxtBox";
            this.ResultadoHanoiTxtBox.Size = new System.Drawing.Size(706, 75);
            this.ResultadoHanoiTxtBox.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 31;
            // 
            // btEjecutarHanoi
            // 
            this.btEjecutarHanoi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btEjecutarHanoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEjecutarHanoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEjecutarHanoi.Location = new System.Drawing.Point(365, 323);
            this.btEjecutarHanoi.Name = "btEjecutarHanoi";
            this.btEjecutarHanoi.Size = new System.Drawing.Size(75, 34);
            this.btEjecutarHanoi.TabIndex = 30;
            this.btEjecutarHanoi.Text = "Ejecutar";
            this.btEjecutarHanoi.UseVisualStyleBackColor = false;
            this.btEjecutarHanoi.Click += new System.EventHandler(this.btEjecutarHanoi_Click);
            // 
            // labelPedirDiscos
            // 
            this.labelPedirDiscos.AutoSize = true;
            this.labelPedirDiscos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedirDiscos.Location = new System.Drawing.Point(300, 262);
            this.labelPedirDiscos.Name = "labelPedirDiscos";
            this.labelPedirDiscos.Size = new System.Drawing.Size(203, 21);
            this.labelPedirDiscos.TabIndex = 29;
            this.labelPedirDiscos.Text = "Dame el numero de discos";
            // 
            // LeerDiscosTxtBox
            // 
            this.LeerDiscosTxtBox.Location = new System.Drawing.Point(334, 297);
            this.LeerDiscosTxtBox.Name = "LeerDiscosTxtBox";
            this.LeerDiscosTxtBox.Size = new System.Drawing.Size(136, 20);
            this.LeerDiscosTxtBox.TabIndex = 28;
            // 
            // DescripcionHanoi
            // 
            this.DescripcionHanoi.AutoSize = true;
            this.DescripcionHanoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionHanoi.Location = new System.Drawing.Point(32, 101);
            this.DescripcionHanoi.Name = "DescripcionHanoi";
            this.DescripcionHanoi.Size = new System.Drawing.Size(689, 21);
            this.DescripcionHanoi.TabIndex = 27;
            this.DescripcionHanoi.Text = "Este algoritmo resulve el problemas de las torres de hanoi en base  al numero de " +
    "dsicos que le des";
            // 
            // TituloHanoi
            // 
            this.TituloHanoi.AutoSize = true;
            this.TituloHanoi.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloHanoi.Location = new System.Drawing.Point(259, 41);
            this.TituloHanoi.Name = "TituloHanoi";
            this.TituloHanoi.Size = new System.Drawing.Size(310, 45);
            this.TituloHanoi.TabIndex = 26;
            this.TituloHanoi.Text = "Las torres de Hanoi";
            // 
            // FrmTorresDeHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReglasHanoi1);
            this.Controls.Add(this.ResultadoHanoiTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btEjecutarHanoi);
            this.Controls.Add(this.labelPedirDiscos);
            this.Controls.Add(this.LeerDiscosTxtBox);
            this.Controls.Add(this.DescripcionHanoi);
            this.Controls.Add(this.TituloHanoi);
            this.Name = "FrmTorresDeHanoi";
            this.Text = "FrmTorresDeHanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ReglasHanoi1;
        private System.Windows.Forms.TextBox ResultadoHanoiTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btEjecutarHanoi;
        private System.Windows.Forms.Label labelPedirDiscos;
        private System.Windows.Forms.TextBox LeerDiscosTxtBox;
        private System.Windows.Forms.Label DescripcionHanoi;
        private System.Windows.Forms.Label TituloHanoi;
    }
}