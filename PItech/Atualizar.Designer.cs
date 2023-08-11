namespace PItech
{
    partial class Atualizar
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.AtualizarPessoa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AtualizarPessoa
            // 
            this.AtualizarPessoa.AutoSize = true;
            this.AtualizarPessoa.BackColor = System.Drawing.Color.Transparent;
            this.AtualizarPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtualizarPessoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AtualizarPessoa.Location = new System.Drawing.Point(37, 102);
            this.AtualizarPessoa.Name = "AtualizarPessoa";
            this.AtualizarPessoa.Size = new System.Drawing.Size(258, 37);
            this.AtualizarPessoa.TabIndex = 1;
            this.AtualizarPessoa.Text = "Atualizar Pessoa";
            this.AtualizarPessoa.Click += new System.EventHandler(this.ExcluirAnimal_Click);
            // 
            // Atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PItech.Properties.Resources.Captura_de_tela_2023_08_10_171511;
            this.Controls.Add(this.AtualizarPessoa);
            this.Name = "Atualizar";
            this.Size = new System.Drawing.Size(631, 464);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AtualizarPessoa;
    }
}
