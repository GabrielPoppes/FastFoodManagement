using FastFoodManagement.DAL;
using FastFoodManagement.View.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        #region Método do botão Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroFuncionarioDAL cadastrar = new CadastroFuncionarioDAL(txbEmail.Text, txbNome.Text, txtBoxCelular.Text, txbPassword.Text, txtBoxRepeatPassword.Text); // Passando os valores do text box
            MessageBox.Show(cadastrar.mensagem);
        }
        #endregion
    }
}
