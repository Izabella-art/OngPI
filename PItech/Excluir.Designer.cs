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
            this.Excluir1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
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
            this.ExcluirAnimal.Click += new System.EventHandler(this.ExcluirAnimal_Click);
            // 
            // Excluir1
            // 
            this.Excluir1.Location = new System.Drawing.Point(81, 153);
            this.Excluir1.Name = "Excluir1";
            this.Excluir1.Size = new System.Drawing.Size(157, 51);
            this.Excluir1.TabIndex = 1;
            this.Excluir1.Text = "Excluir1";
            this.Excluir1.UseVisualStyleBackColor = true;
            this.Excluir1.Click += new System.EventHandler(this.Excluir1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(0, 0);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(465, 62);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(104, 20);
            this.maskedTextBox2.TabIndex = 3;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PItech.Properties.Resources.Captura_de_tela_2023_08_10_171511;
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Excluir1);
            this.Controls.Add(this.ExcluirAnimal);
            this.Name = "Excluir";
            this.Size = new System.Drawing.Size(625, 457);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExcluirAnimal;
        private System.Windows.Forms.Button Excluir1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}
