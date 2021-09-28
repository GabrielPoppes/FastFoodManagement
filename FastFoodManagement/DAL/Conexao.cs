using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodManagement.DAL
{
    public class Conexao
    {
        SqlConnection conexaobd = new SqlConnection();

        #region Método de conexão com o BD
        public Conexao()
        {
            conexaobd.ConnectionString = @"Data Source=DESKTOP-715UFO0\SQLEXPRESS;Initial Catalog=FastFoodManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; // Endereço do banco de dados
        }
        #endregion

        public SqlConnection Conectar()
        {
            if(conexaobd.State == System.Data.ConnectionState.Closed)
            {
                conexaobd.Open();
            }
            return conexaobd;
        }

        #region Método para desconectar do BD
        public void Desconectar()
        {
            if(conexaobd.State == System.Data.ConnectionState.Open)
            {
                conexaobd.Close();
            }
        }
        #endregion
    }
}
