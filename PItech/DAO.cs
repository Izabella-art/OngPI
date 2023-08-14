using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//importando a classe de dados



namespace PItechNovo
{
  

    internal class DAO
    {
        //instanciar a conexão com o mysql
            this.cpf = new long[];//por enqunato esse valor
            this.nome = new string[];
            this.telefone = new string[];
            this.endereco = new string[];
            this.rg = new string[];
            this.datanasc = new string[];
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=PitechNovo;Uid=root;Password=");//servidor banco de dados e senha
            try
            {

                conexao.Open();//abrir a conexao com o banco de dados
                MessageBox.Show("Conectado!");
            }
            catch (Exception Erro)//tratar e encaminhar o erro
            {
                MessageBox.Show("algo deu errado!\n\n" + Erro.Message);
            }//fim do metodo construtor

        }//metodo de insersao que possa servir pra mts tabelas

        public string inserir(long cpf, string nome, string telefone, string endereco, string RG, string datanasc, string nomeTabela)//long atende o big int
        {
            string inserir = $"insert into {nomeTabela}(nome, cpf, telefone, endereco, RG, datanasc) values ('{nome}','{cpf}','{telefone}','{endereco}','{RG}','{datanasc}')";
            //metodo global que atende a qualquer tabela interpolaçao
            //insert into colocando dentro de uma variavel tipo texto
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Executado!";//cntrl enter vai retormar 0 ou 1
            return resultado;
            //variavel para acessar todos os condos o com que vai executar e ond evai executar
        }

        //metodo de consulta
        //pegar os dados que tao no banco e enquanto pegar vaipreench3er um vetor e os dados vem de la e td transaão vai vir direto do vetr

        public void PreencherVetor()
        {
            string query = "select * from pessoa";//comando que faz a seleção

            //instanciar
            this.cpf = new long[100];//por enqunato esse valor
            this.nome = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];
            this.rg = new string[100];
            this.datanasc = new string[100];
            //preparar o comando
            MySqlCommand sql = new MySqlCommand(query, conexao);// chave pra acessar o banco e faz o retorno dentro do sql 
            ///leitor

            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;

            while (leitura.Read()) //ja por padrao é true
            {
                CPF[i] = Convert.ToInt64(leitura["CPF"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                RG[i] = leitura["RG"] + "";
                datanasc[i] = leitura["datanasc"] + "";
                i++;
                contador++;//contando quantos dados estao sendoa armazenados
            }// fim do whilw

            // encerro a comunicação com o banco
            leitura.Close();
        }//fim do metodo


        public int QuantidadeDados()
        {
            return contador;
        }

        public string Atualizar(long cpf, string nomeTabela, string campo, String dado)//atualizar individual
        {
            string query = $"update {nomeTabela} set campo {campo} = '{dado}' where CPF = '{cpf}'"; //comando upade e dps oq tem que ser alterado por isso o '
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;

        }//fim do metodo

        public string Excluir(long cpf, string nomeTabela)
        {
            string query = $" delete from {nomeTabela} where CPF = {cpf}";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "excluido";
            return resultado;

        }//fim do metodo
    }//fim da classe
}