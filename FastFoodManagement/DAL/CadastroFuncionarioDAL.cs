using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodManagement.DAL
{
    public class CadastroFuncionarioDAL
    {
        SqlCommand comando = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem;

        #region Método com as Querys para cadastrar no banco de dados
        public CadastroFuncionarioDAL(string email, string nome, string celular, string senha, string repetirsenha)
        {
            comando.CommandText = "insert into funcionario(email, nome, celular, senha) VALUES(@email, @nome, @celular, @senha)"; // Query para cadastrar o funcionário no BD

            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@celular", celular);
            comando.Parameters.AddWithValue("@senha", senha);

            try
            {
                if(email != "" && nome != "" && celular != "" && senha != "" && repetirsenha != "")
                {
                    if (senha == repetirsenha)
                    {
                        comando.Connection = conexao.Conectar();
                        comando.ExecuteNonQuery();
                        conexao.Desconectar();
                        this.mensagem = "Cadastrado com sucesso!";
                    }

                    else
                    {
                        this.mensagem = "Por favor, as senhas devem ser iguais!";
                    }
                }
                else
                {
                    this.mensagem = "Por favor, preencha todos os campos!";
                }
                
            }

            catch(SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados!";
            }
        }
        #endregion
    }
}
