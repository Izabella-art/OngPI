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

namespace PItech
{

    public partial class ConsultarPessoa : UserControl
    {
        DAO con;
        public ConsultarPessoa()
        {
            con = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();
            NomeColunas();//nomear os titulos das colunas
            AdicionarDados();//preenchendo o datagrid view
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].Name = "cpf";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "endereco";
            dataGridView1.Columns[4].Name = "RG";
            dataGridView1.Columns[5].Name = "datanasc";
        }

        public void NomeColunas()
        {
            
        }

        public void AdicionarDados() //adicionar a quantoidade de linhas que tenho no banco
        {
            con.PreencherVetor();
            for (int i = 0; i < con.QuantidadeDados(); i++)
            {
                dataGridView1.Rows.Add(con.cpf[i], con.nome[i], con.telefone[i], con.endereco[i], con.RG[i], con.datanasc[i]);

            }//adicionando dados no datagrid view
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
