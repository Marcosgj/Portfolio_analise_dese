namespace Portfolio_analise_dese
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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxDivisiveisPor4 = new System.Windows.Forms.TextBox();
            this.textBoxQuadrados = new System.Windows.Forms.TextBox();
            this.textBoxSomaValoresPares = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(38, 62);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(1376, 22);
            this.textBoxResult.TabIndex = 0;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(38, 104);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(1376, 22);
            this.textBoxSum.TabIndex = 1;
            // 
            // textBoxDivisiveisPor4
            // 
            this.textBoxDivisiveisPor4.Location = new System.Drawing.Point(38, 156);
            this.textBoxDivisiveisPor4.Name = "textBoxDivisiveisPor4";
            this.textBoxDivisiveisPor4.Size = new System.Drawing.Size(1376, 22);
            this.textBoxDivisiveisPor4.TabIndex = 2;
            // 
            // textBoxQuadrados
            // 
            this.textBoxQuadrados.Location = new System.Drawing.Point(38, 209);
            this.textBoxQuadrados.Multiline = true;
            this.textBoxQuadrados.Name = "textBoxQuadrados";
            this.textBoxQuadrados.Size = new System.Drawing.Size(1376, 145);
            this.textBoxQuadrados.TabIndex = 3;
            // 
            // textBoxSomaValoresPares
            // 
            this.textBoxSomaValoresPares.Location = new System.Drawing.Point(38, 404);
            this.textBoxSomaValoresPares.Name = "textBoxSomaValoresPares";
            this.textBoxSomaValoresPares.Size = new System.Drawing.Size(1376, 22);
            this.textBoxSomaValoresPares.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 697);
            this.Controls.Add(this.textBoxSomaValoresPares);
            this.Controls.Add(this.textBoxQuadrados);
            this.Controls.Add(this.textBoxDivisiveisPor4);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxDivisiveisPor4;
        private System.Windows.Forms.TextBox textBoxQuadrados;
        private System.Windows.Forms.TextBox textBoxSomaValoresPares;
    }
}

