using PItech;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace PItech
{
    public partial class CadastrarUsuário : UserControl
    {
        DAO cad;// deveria ser cadUsuario porem nao sei de onde ela esta vindo, por enquanto
        public CadastrarUsuário()
        {
            InitializeComponent();
            cad = new DAO();
        }//fim do construtor

        private void CadastrarUsuário_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                string result = cad.inserir(Convert.ToInt64(maskedTextBox1.Text), maskedTextBox2.Text, maskedTextBox3.Text, maskedTextBox4.Text, maskedTextBox5.Text, maskedTextBox6.Text,  "pessoa");
                MessageBox.Show(result);
            }


            catch (Exception Erro)
            {

                MessageBox.Show("algo deu errado!\n\n" + Erro.Message);

            }//fim do try catch
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }//Nome

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }//RG

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }//CPF

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }//Telefone

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }//Endereço

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }//DataDeNascimento


    }
}

