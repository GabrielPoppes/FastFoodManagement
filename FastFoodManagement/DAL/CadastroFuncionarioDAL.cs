using FastFoodManagement.View.Registration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FastFoodManagement.DAL
{
    public class CadastroFuncionarioDAL
    {
        SqlCommand comando = new SqlCommand();
        Conexao con = new Conexao();
        public string mensagem;
        public bool check = false;

        #region Método com as Querys para cadastrar no banco de dados
        public string CadastrarFuncionario(string email, string nome, string celular, string senha, string repetirsenha)
        {
            comando.CommandText = "insert into funcionario(email, nome, celular, senha) VALUES(@email, @nome, @celular, @senha)"; // Query para cadastrar o funcionário no BD

            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@celular", celular);
            comando.Parameters.AddWithValue("@senha", senha);

            try
            {
                comando.Connection = con.Conectar();
                comando.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "Cadastrado com sucesso!";
                check = true;
            }

            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados!";
            }
            return mensagem;
        }
        #endregion
    }
}
