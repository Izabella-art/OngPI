using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Excluir Animal
namespace PItech
{
    public partial class Excluir : UserControl
    {
        DAO exc;
        public Excluir()
        {
            InitializeComponent();
            exc = new DAO();
        }

        private void ExcluirAnimal_Click(object sender, EventArgs e)
        {

            string result = exc.Excluir (Convert.ToInt64(CPF.Text), "pessoa");
            MessageBox.Show(result);
            
        }

        private void Excluir1_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ShowDialog();
        }
    }
}

