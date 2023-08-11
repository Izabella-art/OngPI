namespace PItech
{
    partial class Excluir
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
            this.ExcluirAnimal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExcluirAnimal
            // 
            this.ExcluirAnimal.AutoSize = true;
            this.ExcluirAnimal.BackColor = System.Drawing.Color.Transparent;
            this.ExcluirAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcluirAnimal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExcluirAnimal.Location = new System.Drawing.Point(46, 96);
            this.ExcluirAnimal.Name = "ExcluirAnimal";
            this.ExcluirAnimal.Size = new System.Drawing.Size(220, 37);
            this.ExcluirAnimal.TabIndex = 0;
            this.ExcluirAnimal.Text = "Excluir Animal";
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PItech.Properties.Resources.Captura_de_tela_2023_08_10_171511;
            this.Controls.Add(this.ExcluirAnimal);
            this.Name = "Excluir";
            this.Size = new System.Drawing.Size(625, 457);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExcluirAnimal;
    }
}
