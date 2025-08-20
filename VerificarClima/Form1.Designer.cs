namespace VerificarClima
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.txbTemp = new System.Windows.Forms.TextBox();
            this.btVerificarClima = new System.Windows.Forms.Button();
            this.pibResultado = new System.Windows.Forms.PictureBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.pibIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(112, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(208, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Termômetro";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(28, 87);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(153, 32);
            this.lblTemperatura.TabIndex = 1;
            this.lblTemperatura.Text = "Temperatura:";
            // 
            // txbTemp
            // 
            this.txbTemp.Location = new System.Drawing.Point(187, 96);
            this.txbTemp.Name = "txbTemp";
            this.txbTemp.Size = new System.Drawing.Size(121, 20);
            this.txbTemp.TabIndex = 2;
            this.txbTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTemp_KeyDown);
            // 
            // btVerificarClima
            // 
            this.btVerificarClima.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerificarClima.Location = new System.Drawing.Point(85, 134);
            this.btVerificarClima.Name = "btVerificarClima";
            this.btVerificarClima.Size = new System.Drawing.Size(202, 61);
            this.btVerificarClima.TabIndex = 3;
            this.btVerificarClima.Text = "Verificar Clima";
            this.btVerificarClima.UseVisualStyleBackColor = true;
            this.btVerificarClima.Click += new System.EventHandler(this.btVerificarClima_Click);
            // 
            // pibResultado
            // 
            this.pibResultado.Location = new System.Drawing.Point(99, 226);
            this.pibResultado.Name = "pibResultado";
            this.pibResultado.Size = new System.Drawing.Size(168, 108);
            this.pibResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibResultado.TabIndex = 4;
            this.pibResultado.TabStop = false;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(81, 368);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(0, 24);
            this.lblDia.TabIndex = 5;
            // 
            // pibIcon
            // 
            this.pibIcon.Image = global::VerificarClima.Properties.Resources.termometrozinho;
            this.pibIcon.Location = new System.Drawing.Point(46, 10);
            this.pibIcon.Name = "pibIcon";
            this.pibIcon.Size = new System.Drawing.Size(67, 59);
            this.pibIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIcon.TabIndex = 6;
            this.pibIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.pibIcon);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.pibResultado);
            this.Controls.Add(this.btVerificarClima);
            this.Controls.Add(this.txbTemp);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Termômetro";
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.TextBox txbTemp;
        private System.Windows.Forms.Button btVerificarClima;
        private System.Windows.Forms.PictureBox pibResultado;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.PictureBox pibIcon;
    }
}

