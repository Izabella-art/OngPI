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

//Atualizar Pessoa
namespace PItech
{
    public partial class Atualizar : UserControl
    {
        DAO Atu;
        public Atualizar()
        {
            InitializeComponent();
            Atu= new DAO();
        }

        private void ExcluirAnimal_Click(object sender, EventArgs e)
        {
            
        }//Atualizar pessoa
    }
}
//show. dialog em gato