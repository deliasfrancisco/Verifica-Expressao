namespace Verifica_expressao
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
			this.label1 = new System.Windows.Forms.Label();
			this.TBExpressao = new System.Windows.Forms.TextBox();
			this.BTProcessa = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.TBResultado = new System.Windows.Forms.TextBox();
			this.BTLimpar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Expressão";
			// 
			// TBExpressao
			// 
			this.TBExpressao.Location = new System.Drawing.Point(100, 41);
			this.TBExpressao.Name = "TBExpressao";
			this.TBExpressao.Size = new System.Drawing.Size(100, 20);
			this.TBExpressao.TabIndex = 1;
			// 
			// BTProcessa
			// 
			this.BTProcessa.Location = new System.Drawing.Point(100, 87);
			this.BTProcessa.Name = "BTProcessa";
			this.BTProcessa.Size = new System.Drawing.Size(100, 23);
			this.BTProcessa.TabIndex = 2;
			this.BTProcessa.Text = "Processa";
			this.BTProcessa.UseVisualStyleBackColor = true;
			this.BTProcessa.Click += new System.EventHandler(this.BTProcessa_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Resultado";
			// 
			// TBResultado
			// 
			this.TBResultado.Enabled = false;
			this.TBResultado.Location = new System.Drawing.Point(100, 180);
			this.TBResultado.Name = "TBResultado";
			this.TBResultado.Size = new System.Drawing.Size(100, 20);
			this.TBResultado.TabIndex = 4;
			// 
			// BTLimpar
			// 
			this.BTLimpar.Location = new System.Drawing.Point(100, 138);
			this.BTLimpar.Name = "BTLimpar";
			this.BTLimpar.Size = new System.Drawing.Size(100, 23);
			this.BTLimpar.TabIndex = 5;
			this.BTLimpar.Text = "Limpar";
			this.BTLimpar.UseVisualStyleBackColor = true;
			this.BTLimpar.Click += new System.EventHandler(this.BTLimpar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 229);
			this.Controls.Add(this.BTLimpar);
			this.Controls.Add(this.TBResultado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BTProcessa);
			this.Controls.Add(this.TBExpressao);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Verifica expressão";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBExpressao;
        private System.Windows.Forms.Button BTProcessa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBResultado;
		private System.Windows.Forms.Button BTLimpar;
	}
}

