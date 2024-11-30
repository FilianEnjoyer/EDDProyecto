namespace EDDemo.Estructuras_Lineales
{
    partial class FrmCola
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
            this.BtDequeue = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtQueue = new System.Windows.Forms.Button();
            this.TxResultado = new System.Windows.Forms.TextBox();
            this.BtColaVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Informacion";
            // 
            // TxInfo
            // 
            this.TxInfo.Location = new System.Drawing.Point(46, 371);
            this.TxInfo.Multiline = true;
            this.TxInfo.Name = "TxInfo";
            this.TxInfo.Size = new System.Drawing.Size(326, 44);
            this.TxInfo.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Escriba un dato";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(556, 36);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(73, 25);
            this.Titulo.TabIndex = 38;
            this.Titulo.Text = "COLA";
            // 
            // TxInPut
            // 
            this.TxInPut.Location = new System.Drawing.Point(46, 174);
            this.TxInPut.Name = "TxInPut";
            this.TxInPut.Size = new System.Drawing.Size(326, 20);
            this.TxInPut.TabIndex = 37;
            // 
            // BtDequeue
            // 
            this.BtDequeue.Location = new System.Drawing.Point(297, 230);
            this.BtDequeue.Name = "BtDequeue";
            this.BtDequeue.Size = new System.Drawing.Size(75, 23);
            this.BtDequeue.TabIndex = 36;
            this.BtDequeue.Text = "Dequeue";
            this.BtDequeue.UseVisualStyleBackColor = true;
            this.BtDequeue.Click += new System.EventHandler(this.BtDequeue_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(174, 230);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtBuscar.TabIndex = 35;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtQueue
            // 
            this.BtQueue.Location = new System.Drawing.Point(46, 230);
            this.BtQueue.Name = "BtQueue";
            this.BtQueue.Size = new System.Drawing.Size(75, 23);
            this.BtQueue.TabIndex = 34;
            this.BtQueue.Text = "Queue";
            this.BtQueue.UseVisualStyleBackColor = true;
            this.BtQueue.Click += new System.EventHandler(this.BtQueue_Click);
            // 
            // TxResultado
            // 
            this.TxResultado.Location = new System.Drawing.Point(392, 66);
            this.TxResultado.Multiline = true;
            this.TxResultado.Name = "TxResultado";
            this.TxResultado.Size = new System.Drawing.Size(385, 349);
            this.TxResultado.TabIndex = 33;
            // 
            // BtColaVaciar
            // 
            this.BtColaVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtColaVaciar.Location = new System.Drawing.Point(24, 36);
            this.BtColaVaciar.Name = "BtColaVaciar";
            this.BtColaVaciar.Size = new System.Drawing.Size(97, 48);
            this.BtColaVaciar.TabIndex = 32;
            this.BtColaVaciar.Text = "Vaciar";
            this.BtColaVaciar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtColaVaciar.UseVisualStyleBackColor = true;
            this.BtColaVaciar.Click += new System.EventHandler(this.BtColaVaciar_Click);
            // 
            // FrmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.TxInPut);
            this.Controls.Add(this.BtDequeue);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.BtQueue);
            this.Controls.Add(this.TxResultado);
            this.Controls.Add(this.BtColaVaciar);
            this.Name = "FrmCola";
            this.Text = "FrmCola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox TxInPut;
        private System.Windows.Forms.Button BtDequeue;
        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtQueue;
        private System.Windows.Forms.TextBox TxResultado;
        private System.Windows.Forms.Button BtColaVaciar;
    }
}