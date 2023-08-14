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
    public partial class EstoqueDeDoações : UserControl
    {
        DAO est;
        public EstoqueDeDoações()
        {
            InitializeComponent();
            est = new DAO();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDialog();
        }
    }
}
