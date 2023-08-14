using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PItech
{
    public partial class CadastrarAnimal : Form
    {
        DAO cadAnimal;
        public CadastrarAnimal()
        {
            InitializeComponent();
            cadAnimal= new DAO();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ShowDialog();
        }

        private void Nome_Click(object sender, EventArgs e)
        {
            ShowDialog();
        }

        private void CadastrarAnimal_Load(object sender, EventArgs e)
        {
            ShowDialog();
        }

        private void Raça_Click(object sender, EventArgs e)
        {
            ShowDialog();
        }

        private void Porte_Click(object sender, EventArgs e)
        {
            ShowDialog();
        }

        private void Idade_Click(object sender, EventArgs e)
        {
            ShowDialog();
        }
    }
}
