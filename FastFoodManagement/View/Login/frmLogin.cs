using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

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

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            txbPassword.PasswordChar = '*';
        }
    }
}
