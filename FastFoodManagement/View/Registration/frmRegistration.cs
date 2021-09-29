using FastFoodManagement.DAL;
using FastFoodManagement.Models;
using FastFoodManagement.View.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodManagement.View.Registration
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        #region Evento TextChanged (colocar asterisco na senha)
        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            txbPassword.PasswordChar = '*';
        }
        #endregion

        #region Evento TextChanged (colocar asterisco no repetir senha)

        private void txtBoxRepeatPassword_TextChanged(object sender, EventArgs e)
        {
            txtBoxRepeatPassword.PasswordChar = '*';
        }
        #endregion

        #region Botão voltar
        public void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.openChildForm(new frmLogin());
        }


        #endregion

        #region Método do botão Cadastrar (com condições de cadastro)
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Condições antes de efetuar o cadastro
            if (txbEmail.Text != "" && txbNome.Text != "" && txtBoxCelular.Text != "" && txbPassword.Text != "" && txtBoxRepeatPassword.Text != "")
            {
                if (txbPassword.Text == txtBoxRepeatPassword.Text)
                {
                    Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$"); // Checando se o e-mail é válido!
                    if (rg.IsMatch(txbEmail.Text))
                    {
                        Regex regex = new Regex(@"^(\([0-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$"); // checando se o celular digitado é válido
                        Match match = regex.Match(txtBoxCelular.Text);
                        if (match.Success)
                        {
                            Controle controle = new Controle();
                            string mensagem = controle.Cadastrar(txbEmail.Text, txbNome.Text, txtBoxCelular.Text, txbPassword.Text, txtBoxRepeatPassword.Text); // Passando os valores do text box
                            if (controle.verificacao)
                            {
                                MessageBox.Show("Cadastro realizado!");
                                LimparCampos(); // Limpar os campos (text box)
                            }
                            
                        }

                        else
                        {
                            MessageBox.Show("Por favor, digite um celular válido!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("E-mail inválido!");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, as senhas devem ser iguais!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
        }
        #endregion

        #region Limpar todos os campos de entrada (text box)
        public void LimparCampos()
        {

            txbNome.Clear();
            txbEmail.Clear();
            txtBoxCelular.Clear();
            txbPassword.Clear();
            txtBoxRepeatPassword.Clear();

        }
        #endregion
    }
}
