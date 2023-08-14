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
    public partial class Form1 : Form
    {
        CadastrarUsuário cad;
        CadastrarAdotante cadAdotante;
        CadastrarAnimal cadAnimal;
        ConsultarPessoa con;
        Atualizar atu;
        Excluir exc;
        EstoqueDeDoações est;
        DAO consul;//fim do construtor
        //houl de entrada DAO = conectar;conectar =new DAO();//ligando o formulario ao conetor do banco

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            cadAnimal.ShowDialog();//abre a tela
        }//Cadastrar Animal

        private void AtualizarPessoa_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();//abre a tela
        }//Atualizar Pessoa

        private void ConsultarPessoa_Click(object sender, EventArgs e)
        {
            con.ShowDialog();//abre a tela
        }

        private void ExcluirAnimal_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();//abre a tela
        }

        private void Estoque_Click(object sender, EventArgs e)
        {
            est.ShowDialog();//abre a tela
        }

        private void CadastrarUsuario_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();//abre a tela
        }

        private void CadastrarAdotante_Click(object sender, EventArgs e)
        {
            cadAdotante.ShowDialog();//abre a tela
        }
    }
}

