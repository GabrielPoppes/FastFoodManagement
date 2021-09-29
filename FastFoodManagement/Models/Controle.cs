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

        #region Método para acessar a conta (login)
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

        #region Método para cadastrar a conta
        public string Cadastrar(string email, string nome, string celular, string senha, string repetirsenha)
        {
            CadastroFuncionarioDAL cadastroDAL = new CadastroFuncionarioDAL();
            this.mensagem = cadastroDAL.CadastrarFuncionario(email, nome, celular, senha, repetirsenha);
            if (cadastroDAL.check)
            {
                this.verificacao = true;
            }
            return mensagem;
        }
        #endregion
    }
}
