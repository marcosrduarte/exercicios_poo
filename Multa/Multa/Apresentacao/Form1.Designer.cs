namespace Multa
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
            this.txbVelocidadeVia = new System.Windows.Forms.TextBox();
            this.lblVelocidade_da_Via = new System.Windows.Forms.Label();
            this.lbl_Velocidade_Registrada = new System.Windows.Forms.Label();
            this.txbVelocidadeRegistrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbValorMultaReferencia = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbVelocidadeVia
            // 
            this.txbVelocidadeVia.Location = new System.Drawing.Point(51, 57);
            this.txbVelocidadeVia.Name = "txbVelocidadeVia";
            this.txbVelocidadeVia.Size = new System.Drawing.Size(201, 22);
            this.txbVelocidadeVia.TabIndex = 0;
            // 
            // lblVelocidade_da_Via
            // 
            this.lblVelocidade_da_Via.AutoSize = true;
            this.lblVelocidade_da_Via.Location = new System.Drawing.Point(49, 31);
            this.lblVelocidade_da_Via.Name = "lblVelocidade_da_Via";
            this.lblVelocidade_da_Via.Size = new System.Drawing.Size(122, 17);
            this.lblVelocidade_da_Via.TabIndex = 2;
            this.lblVelocidade_da_Via.Text = "Velocidade da Via";
            // 
            // lbl_Velocidade_Registrada
            // 
            this.lbl_Velocidade_Registrada.AutoSize = true;
            this.lbl_Velocidade_Registrada.Location = new System.Drawing.Point(48, 88);
            this.lbl_Velocidade_Registrada.Name = "lbl_Velocidade_Registrada";
            this.lbl_Velocidade_Registrada.Size = new System.Drawing.Size(151, 17);
            this.lbl_Velocidade_Registrada.TabIndex = 3;
            this.lbl_Velocidade_Registrada.Text = "Velocidade Registrada";
            // 
            // txbVelocidadeRegistrada
            // 
            this.txbVelocidadeRegistrada.Location = new System.Drawing.Point(51, 114);
            this.txbVelocidadeRegistrada.Name = "txbVelocidadeRegistrada";
            this.txbVelocidadeRegistrada.Size = new System.Drawing.Size(201, 22);
            this.txbVelocidadeRegistrada.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor de referência da multa";
            // 
            // txbValorMultaReferencia
            // 
            this.txbValorMultaReferencia.Location = new System.Drawing.Point(51, 171);
            this.txbValorMultaReferencia.Name = "txbValorMultaReferencia";
            this.txbValorMultaReferencia.Size = new System.Drawing.Size(201, 22);
            this.txbValorMultaReferencia.TabIndex = 6;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(106, 247);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(12, 311);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(68, 17);
            this.lblResposta.TabIndex = 8;
            this.lblResposta.Text = "Resposta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 384);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txbValorMultaReferencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbVelocidadeRegistrada);
            this.Controls.Add(this.lbl_Velocidade_Registrada);
            this.Controls.Add(this.lblVelocidade_da_Via);
            this.Controls.Add(this.txbVelocidadeVia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbVelocidadeVia;
        private System.Windows.Forms.Label lblVelocidade_da_Via;
        private System.Windows.Forms.Label lbl_Velocidade_Registrada;
        private System.Windows.Forms.TextBox txbVelocidadeRegistrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbValorMultaReferencia;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblResposta;
    }
}

