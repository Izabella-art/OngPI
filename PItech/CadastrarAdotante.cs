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
    public partial class CadastrarAdotante : Form
    {
        DAO cadAdotante;
        public CadastrarAdotante()
        {
            InitializeComponent();
            cadAdotante= new DAO();
        }

        private void Cachorro_Click(object sender, EventArgs e)
        {
            ShowDialog(this);
        }//cachorro

        private void CadastrarAdotante_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//sexo

        private void porte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//porte

        private void idade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//idade

        private void Gato_Click(object sender, EventArgs e)
        {
            ShowDialog();
        }//gato
    }
}
