using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodManagement.DAL
{
    public class FuncionarioDAL
    {
        SqlCommand comando = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem;

        public FuncionarioDAL(string email, string nome, string celular, string senha)
        {
            comando.CommandText = "insert into funcionario(email, nome, celular, senha) VALUES(@email, @nome, @celular, @senha)"; // Query para incluir no BD

            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@celular", celular);
            comando.Parameters.AddWithValue("@senha", senha);

            try
            {
                comando.Connection = conexao.Conectar();
                comando.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Cadastrado com sucesso!";
            }

            catch(SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados!";
            }
        }
    }
}
