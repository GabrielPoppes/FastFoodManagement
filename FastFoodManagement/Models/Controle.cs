using FastFoodManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodManagement.Models
{
    class Controle
    {
        public bool verificacao;
        public string mensagem = "";

        #region Método para acessar a conta
        public bool Acessar(string email, string senha) // Método para acessar a conta
        {
            LoginFuncionarioDAL loginDAL = new LoginFuncionarioDAL();
            verificacao = loginDAL.CheckLogin(email, senha);

            if (!loginDAL.mensagem.Equals(""))
            {
                this.mensagem = loginDAL.mensagem;
            }
            return verificacao;
        }
        #endregion
    }
}
