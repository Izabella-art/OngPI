namespace PItech
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
            this.Cadastrar = new System.Windows.Forms.Button();
            this.AtualizarPessoa = new System.Windows.Forms.Button();
            this.ConsultarPessoa = new System.Windows.Forms.Button();
            this.ExcluirAnimal = new System.Windows.Forms.Button();
            this.Estoque = new System.Windows.Forms.Button();
            this.CadastrarUsuario = new System.Windows.Forms.Button();
            this.CadastrarAdotante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(107, 12);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(135, 63);
            this.Cadastrar.TabIndex = 0;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // AtualizarPessoa
            // 
            this.AtualizarPessoa.Location = new System.Drawing.Point(107, 81);
            this.AtualizarPessoa.Name = "AtualizarPessoa";
            this.AtualizarPessoa.Size = new System.Drawing.Size(135, 61);
            this.AtualizarPessoa.TabIndex = 1;
            this.AtualizarPessoa.Text = "Atualizar";
            this.AtualizarPessoa.UseVisualStyleBackColor = true;
            this.AtualizarPessoa.Click += new System.EventHandler(this.AtualizarPessoa_Click);
            // 
            // ConsultarPessoa
            // 
            this.ConsultarPessoa.Location = new System.Drawing.Point(107, 148);
            this.ConsultarPessoa.Name = "ConsultarPessoa";
            this.ConsultarPessoa.Size = new System.Drawing.Size(135, 62);
            this.ConsultarPessoa.TabIndex = 2;
            this.ConsultarPessoa.Text = "Consultar";
            this.ConsultarPessoa.UseVisualStyleBackColor = true;
            this.ConsultarPessoa.Click += new System.EventHandler(this.ConsultarPessoa_Click);
            // 
            // ExcluirAnimal
            // 
            this.ExcluirAnimal.Location = new System.Drawing.Point(107, 216);
            this.ExcluirAnimal.Name = "ExcluirAnimal";
            this.ExcluirAnimal.Size = new System.Drawing.Size(135, 62);
            this.ExcluirAnimal.TabIndex = 3;
            this.ExcluirAnimal.Text = "Excluir";
            this.ExcluirAnimal.UseVisualStyleBackColor = true;
            this.ExcluirAnimal.Click += new System.EventHandler(this.ExcluirAnimal_Click);
            // 
            // Estoque
            // 
            this.Estoque.Location = new System.Drawing.Point(107, 294);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(135, 57);
            this.Estoque.TabIndex = 4;
            this.Estoque.Text = "Estoque";
            this.Estoque.UseVisualStyleBackColor = true;
            this.Estoque.Click += new System.EventHandler(this.Estoque_Click);
            // 
            // CadastrarUsuario
            // 
            this.CadastrarUsuario.Location = new System.Drawing.Point(278, 12);
            this.CadastrarUsuario.Name = "CadastrarUsuario";
            this.CadastrarUsuario.Size = new System.Drawing.Size(140, 63);
            this.CadastrarUsuario.TabIndex = 5;
            this.CadastrarUsuario.Text = "CadastrarUsuario";
            this.CadastrarUsuario.UseVisualStyleBackColor = true;
            this.CadastrarUsuario.Click += new System.EventHandler(this.CadastrarUsuario_Click);
            // 
            // CadastrarAdotante
            // 
            this.CadastrarAdotante.Location = new System.Drawing.Point(278, 81);
            this.CadastrarAdotante.Name = "CadastrarAdotante";
            this.CadastrarAdotante.Size = new System.Drawing.Size(140, 61);
            this.CadastrarAdotante.TabIndex = 6;
            this.CadastrarAdotante.Text = "CadastrarAdotante";
            this.CadastrarAdotante.UseVisualStyleBackColor = true;
            this.CadastrarAdotante.Click += new System.EventHandler(this.CadastrarAdotante_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 397);
            this.Controls.Add(this.CadastrarAdotante);
            this.Controls.Add(this.CadastrarUsuario);
            this.Controls.Add(this.Estoque);
            this.Controls.Add(this.ExcluirAnimal);
            this.Controls.Add(this.ConsultarPessoa);
            this.Controls.Add(this.AtualizarPessoa);
            this.Controls.Add(this.Cadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button AtualizarPessoa;
        private System.Windows.Forms.Button ConsultarPessoa;
        private System.Windows.Forms.Button ExcluirAnimal;
        private System.Windows.Forms.Button Estoque;
        private System.Windows.Forms.Button CadastrarUsuario;
        private System.Windows.Forms.Button CadastrarAdotante;
    }
}

