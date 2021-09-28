using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodManagement.Modelo
{
    public class Controle
    {
        public bool verificacao;
        public string mensagem = "";

        #region Método para acessar a conta
        public bool Acessar(string email, string senha)
        {
            return verificacao;
        }
        #endregion

        #region Método para cadastrar a conta
        public string Cadastrar(string email, string celular, string senha, string lembretesenha)
        {
            return mensagem;
        }
        #endregion
    }
}
