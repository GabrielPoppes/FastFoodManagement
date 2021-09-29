using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodManagement.DAL
{
    class LoginFuncionarioDAL
    {
        public bool check = false;
        public string mensagem = "";
        SqlCommand comando = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader armazenarDados;

        #region Método para checar o acesso (login)
        public bool CheckLogin(string email, string senha)
        {
            comando.CommandText = "select * from funcionario where email = @email and senha = @senha";

            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senha);

            try
            {
                comando.Connection = con.Conectar();
                armazenarDados = comando.ExecuteReader();

                if (armazenarDados.HasRows)
                {
                    check = true;
                }

                con.Desconectar();
                armazenarDados.Close();
            }

            catch (SqlException)
            {
                this.mensagem = "Erro no acesso!";
            }
            return check;
        }
        #endregion
    }
}
