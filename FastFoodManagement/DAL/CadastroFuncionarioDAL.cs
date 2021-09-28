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
                if(email != "" && nome != "" && celular != "" && senha != "" && repetirsenha != "") // Checando se os campos não estão vazios
                {
                    if (senha == repetirsenha) // Checando se a senha e repetir senha estão iguais
                    {
                        Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$"); // Checando se o e-mail digitado é válido
                        if (rg.IsMatch(email))
                        {
                            Regex regex = new Regex(@"^(\([0-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$"); // checando se o celular digitado é válido
                            Match match = regex.Match(celular);
                            if (match.Success)
                            {
                                comando.Connection = conexao.Conectar();
                                comando.ExecuteNonQuery();
                                conexao.Desconectar();
                                this.mensagem = "Cadastrado com sucesso!";
                            }
                            else
                            {
                                this.mensagem = "Por favor, digite um celular válido!";
                            }                            
                        }

                        else
                        {
                            this.mensagem = "E-mail inválido!";
                        }
                        
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
