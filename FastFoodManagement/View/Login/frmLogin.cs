using FastFoodManagement.DAL;
using FastFoodManagement.Models;
using FastFoodManagement.View.BoxService;
using FastFoodManagement.View.Registration;
using FastFoodManagement.View.SystemOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodManagement.View.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            HideButtonReturn(); // Esconder botão voltar
        }

        #region Passando o nome do usuário que se logou para a tabela ultimologin
        private void GetNameLogin()
        {
            SqlDataAdapter da;
            DataSet ds;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-715UFO0\SQLEXPRESS;Initial Catalog=FastFoodManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); // Endereço do banco de dados
            con.Open();

            /* CÓDIGO 1 - OBTER O NOME DO BANCO DE DADOS, DE ACORDO COM O E-MAIL QUE FOI DIGITADO */
            string emailFuncionario = Convert.ToString(txbEmail.Text); // E-mail digitado no text box

            SqlCommand cmd = new SqlCommand($"select nome from funcionario where email = '{emailFuncionario}';", con); // Comando para obter o nome do e-mail digitado
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "FastFoodManager");
            dt = ds.Tables["FastFoodManager"];
            string nomeSelecionado = dt.Rows[0].ItemArray[0].ToString(); // Recebendo o nome do e-mail na string nomeSelecionado
            /* FIM CÓDIGO 1 */

            /* CÓDIGO 2 - PASSAR O NOME DIGITADO PARA O BD ULTIMOLOGIN */
            SqlCommand cmdInserção = new SqlCommand($"insert into ultimologin(nome) values('{nomeSelecionado}');", con); // Comando para obter o nome do e-mail digitado
            da = new SqlDataAdapter(cmdInserção);
            da.Fill(ds, "FastFoodManager");

            dt = ds.Tables["FastFoodManager"];
            con.Close();
            /* FIM DO CÓDIGO 2 */
        }
        #endregion

        #region Evento click no text box e-mail (para sumir o text pré definido)
        private void txbEmail_Click(object sender, EventArgs e)
        {
            txbEmail.Clear();
        }
        #endregion

        #region Evento click no text box e-mail (para sumir o text pré definido)
        private void txbPassword_Click(object sender, EventArgs e)
        {
            txbPassword.Clear();
        }
        #endregion

        #region Evento textchanged para trocar o texto digitado em senha por asterisco
        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            txbPassword.PasswordChar = '*';
        }
        #endregion

        #region Botão entrar (abrindo a tela de opções após clicar em entrar)
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Acessar(txbEmail.Text, txbPassword.Text);

            if (controle.mensagem.Equals(""))
            {
                if (controle.verificacao)
                {
                    GetNameLogin();
                    MessageBox.Show("Logado com sucesso!");
                    openChildForm(new frmSystemOptions());
                }
                else
                {
                    MessageBox.Show("Dados incorretos!");
                }
            }

            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
        #endregion

        #region Botão sair (evento click)
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Botão voltar (evento click)
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            HideButtonReturn();
            ShowButtonExit();
            openChildForm(new frmLogin());
        }
        #endregion

        #region Botão cadastrar (evento click)
        public void btnCadastrar_Click(object sender, EventArgs e)
        {
            HideButtonExit();
            ShowButtonReturn();
            openChildForm(new frmRegistration());
        }
        #endregion

        #region Método para abrir o panel do Registro
        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Método para Esconder botão VOLTAR
        private void HideButtonReturn()
        {
            btnVoltar.Hide();
        }
        #endregion

        #region Método para Mostrar botão VOLTAR
        private void ShowButtonReturn()
        {
            btnVoltar.Show();
        }
        #endregion

        #region Método para Mostrar botão SAIR
        private void ShowButtonExit()
        {
            btnSair.Show();
        }
        #endregion

        #region Método para Esconder botão SAIR
        private void HideButtonExit()
        {
            btnSair.Hide();
        }
        #endregion

    }
}
