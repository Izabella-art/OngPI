namespace PItech
{
    partial class CadastrarAnimal
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Idade = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.Raça = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.Porte = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.Situação = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Romantic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(253, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Animal";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(18, 70);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(66, 22);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome:";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.Bisque;
            this.maskedTextBox1.Location = new System.Drawing.Point(88, 70);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(191, 20);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Idade
            // 
            this.Idade.AutoSize = true;
            this.Idade.BackColor = System.Drawing.Color.Transparent;
            this.Idade.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idade.Location = new System.Drawing.Point(18, 119);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(64, 22);
            this.Idade.TabIndex = 3;
            this.Idade.Text = "Idade:";
            this.Idade.Click += new System.EventHandler(this.Idade_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.Bisque;
            this.maskedTextBox2.Location = new System.Drawing.Point(88, 124);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(191, 20);
            this.maskedTextBox2.TabIndex = 4;
            // 
            // Raça
            // 
            this.Raça.AutoSize = true;
            this.Raça.BackColor = System.Drawing.Color.Transparent;
            this.Raça.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raça.Location = new System.Drawing.Point(18, 182);
            this.Raça.Name = "Raça";
            this.Raça.Size = new System.Drawing.Size(57, 22);
            this.Raça.TabIndex = 5;
            this.Raça.Text = "Raça:";
            this.Raça.Click += new System.EventHandler(this.Raça_Click);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.Color.Bisque;
            this.maskedTextBox3.Location = new System.Drawing.Point(88, 184);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(191, 20);
            this.maskedTextBox3.TabIndex = 6;
            // 
            // Porte
            // 
            this.Porte.AutoSize = true;
            this.Porte.BackColor = System.Drawing.Color.Transparent;
            this.Porte.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Porte.Location = new System.Drawing.Point(18, 247);
            this.Porte.Name = "Porte";
            this.Porte.Size = new System.Drawing.Size(64, 22);
            this.Porte.TabIndex = 7;
            this.Porte.Text = "Porte:";
            this.Porte.Click += new System.EventHandler(this.Porte_Click);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BackColor = System.Drawing.Color.Bisque;
            this.maskedTextBox4.Location = new System.Drawing.Point(88, 249);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(191, 20);
            this.maskedTextBox4.TabIndex = 8;
            // 
            // Situação
            // 
            this.Situação.AutoSize = true;
            this.Situação.BackColor = System.Drawing.Color.Transparent;
            this.Situação.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Situação.Location = new System.Drawing.Point(429, 65);
            this.Situação.Name = "Situação";
            this.Situação.Size = new System.Drawing.Size(189, 22);
            this.Situação.TabIndex = 9;
            this.Situação.Text = "Situação - Descrição:";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.BackColor = System.Drawing.Color.Bisque;
            this.maskedTextBox5.Location = new System.Drawing.Point(442, 90);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(166, 20);
            this.maskedTextBox5.TabIndex = 10;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            // 
            // CadastrarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::PItech.Properties.Resources.Captura_de_tela_2023_08_10_171511;
            this.ClientSize = new System.Drawing.Size(630, 457);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.Situação);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.Porte);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.Raça);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CadastrarAnimal";
            this.Text = "CadastrarAnimal";
            this.Load += new System.EventHandler(this.CadastrarAnimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label Idade;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label Raça;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label Porte;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label Situação;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.ImageList imageList1;
    }
}