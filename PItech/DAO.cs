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
        public MySqlConnection conexao;//por enqunato esse valor
        public long[] cpf;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public string[] rg;
        public long[] datanasc;
        public int i;
        public int contador;
        public string[] Nome;//Animal
        public long[] Raca;
        public string[] Porte;
        public string[] SituacaoDescricao;
        public string[] Genero;
        public string[] AnosDeVida;
        public string[] Tamanho;//AnimalAdotado
        public string[] Sexo;
        public string[] TipoAnimal;
        public string[] idade;



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

        public string inserir(long cpf, string nome, string telefone, string endereco, string rg, string datanasc, string TabelaCliente)//long atende o big int
        {
            string inserir = $"insert into {TabelaCliente}(nome, cpf, telefone, endereco, RG, datanasc) values ('{nome}','{cpf}','{telefone}','{endereco}','{rg}','{datanasc}')";

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
            this.datanasc = new long[100];
            //preparar o comando
            MySqlCommand sql = new MySqlCommand(query, conexao);// chave pra acessar o banco e faz o retorno dentro do sql 
            ///leitor

            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;

            while (leitura.Read()) //ja por padrao é true
            {
                cpf[i] = Convert.ToInt64(leitura["CPF"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                rg[i] = leitura["RG"] + "";
                datanasc[i] = Convert.ToInt64(leitura["datanasc"]);
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

        public string cadAnimal(long Nome, string Raca, string Porte, string SituacaoDescricao, string Genero, string AnosDeVida, string TabelaAnimal)//long atende o big int
        {
            string inserir = $"insert into {TabelaAnimal}(Nome, Raca, Porte, SituacaoDescricao, Genero, AnosDeVida) values ('{Nome}','{Raca}','{Porte}','{SituacaoDescricao}','{Genero}','{AnosDeVida}')";

            //metodo global que atende a qualquer tabela interpolaçao
            //insert into colocando dentro de uma variavel tipo texto
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Executado!";//cntrl enter vai retormar 0 ou 1
            return resultado;
            //variavel para acessar todos os condos o com que vai executar e ond evai executar
        }

        //metodo de consulta
        //pegar os dados que tao no banco e enquanto pegar vaipreench3er um vetor e os dados vem de la e td transaão vai vir direto do vetr

        public void PreencherVetorAnimal()
        {
            string query = "select * from pessoa";//comando que faz a seleção

            //instanciar
            this.Nome = new string[100];//por enqunato esse valor
            this.Raca = new long[100];
            this.Porte = new string[100];
            this.SituacaoDescricao = new string[100];
            this.Genero = new string[100];
            this.AnosDeVida = new string[100];
            //preparar o comando
            MySqlCommand sql = new MySqlCommand(query, conexao);// chave pra acessar o banco e faz o retorno dentro do sql 
            ///leitor

            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;

            while (leitura.Read()) //ja por padrao é true
            {
                Nome[i] = leitura["Nome"] + "";
                Raca[i] = Convert.ToInt64(leitura["Raca"]);
                Porte[i] = leitura["Porte"] + "";
                SituacaoDescricao[i] = leitura["SituacaoDescricao"] + "";
                Genero[i] = leitura["Genero"] +"";
                AnosDeVida[i] = leitura["AnosDeVida"] + "";
                i++;
                contador++;//contando quantos dados estao sendoa armazenados
            }// fim do while

            // encerro a comunicação com o banco
            leitura.Close();
        }//fim do metodo


        public int QuantidadeDadosAnimal()
        {
            return contador;
        }

        public string AtualizarAnimalCliente(string SituacaoDescricao, string TabelaAnimal, string campo, String dado)//atualizar individual
        {
            string query = $"update {TabelaAnimal} set campo {campo} = '{dado}' where CPF = '{SituacaoDescricao}'"; //comando upade e dps oq tem que ser alterado por isso o '
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;

        }//fim do metodo

        public string ExcluirAnimalCliente(string AnosDeVida, string TabelaAnimal)
        {
            string query = $" delete from {TabelaAnimal} where idade = {AnosDeVida}";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "excluido";
            return resultado;

        }//fim do metodo



        public string inserirAnimalAdotado(string idade, string tipoanimal, string sexo, string tamanho, string TabelaAnimalAdotado)//long atende o big int
        {
            string inserir = $"insert into {TabelaAnimalAdotado}(idade, tipoanimal, sexo, tamanho) values ('{idade}','{tipoanimal}','{sexo}','{tamanho}')";

            //metodo global que atende a qualquer tabela interpolaçao
            //insert into colocando dentro de uma variavel tipo texto
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Executado!";//cntrl enter vai retormar 0 ou 1
            return resultado;
            //variavel para acessar todos os condos o com que vai executar e ond evai executar
        }

        //metodo de consulta
        //pegar os dados que tao no banco e enquanto pegar vaipreench3er um vetor e os dados vem de la e td transaão vai vir direto do vetr

        public void PreencherVetorAnimalAdotado()
        {
            string query = "select * from PetAdotante";//comando que faz a seleção

            //instanciar
            this.idade = new string[100];//por enqunato esse valor
            this.TipoAnimal = new string[100];
            this.Sexo = new string[100];
            this.Tamanho = new string[100];
         
            //preparar o comando
            MySqlCommand sql = new MySqlCommand(query, conexao);// chave pra acessar o banco e faz o retorno dentro do sql 
            ///leitor

            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;

            while (leitura.Read()) //ja por padrao é true
            {
                idade[i] = leitura["CPF"] +"";
                TipoAnimal[i] = leitura["TipoAnimal"] + "";
                Sexo[i] = leitura["Sexo"] + "";
                Tamanho[i] = leitura["Tamanho"] + "";
                i++;
                contador++;//contando quantos dados estao sendoa armazenados
            }// fim do whilw

            // encerro a comunicação com o banco
            leitura.Close();
        }//fim do metodo


        public int QuantidadeDadosAnimalAdotado()
        {
            return contador;
        }

        public string AtualizarAnimalAdotado(long idade, string TabelaAnimalAdotado, string campo, String dado)//atualizar individual
        {
            string query = $"update {TabelaAnimalAdotado} set campo {campo} = '{dado}' where CPF = '{idade}'"; //comando upade e dps oq tem que ser alterado por isso o '
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;

        }//fim do metodo

        public string ExcluirAnimalAdotado(long tamanho, string TabelaAnimalAdotado)
        {
            string query = $" delete from {TabelaAnimalAdotado} where CPF = {cpf}";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "excluido";
            return resultado;

        }//fim do metodo

    }        
    


}//fim da classe

