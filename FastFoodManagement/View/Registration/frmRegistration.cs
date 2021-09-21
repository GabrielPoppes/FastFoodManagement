﻿using System;
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

        #region Evento quando clica no text box e-mail
        private void txbEmail_Click(object sender, EventArgs e)
        {
            txbEmail.Clear();
        }
        #endregion

        #region Evento quando clica no text box celular

        private void txtBoxCelular_Click(object sender, EventArgs e)
        {
            txtBoxCelular.Clear();
        }
        #endregion

        #region Evento quando clica no text box senha
        private void txbPassword_Click(object sender, EventArgs e)
        {
            txbPassword.Clear();
        }
        #endregion

        #region Evento quando clica no text box Repetir senha

        private void txtBoxRepeatPassword_Click(object sender, EventArgs e)
        {
            txtBoxRepeatPassword.Clear();
        }
        #endregion

        #region Evento quando clica no text box Lembrete senha

        private void txtBoxLembrete_Click(object sender, EventArgs e)
        {
            txtBoxLembrete.Clear();
        }
        #endregion

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
    }
}
