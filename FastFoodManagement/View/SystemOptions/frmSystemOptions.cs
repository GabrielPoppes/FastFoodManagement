using FastFoodManagement.View.BoxService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodManagement.View.SystemOptions
{
    public partial class frmSystemOptions : Form
    {
        public frmSystemOptions()
        {
            InitializeComponent();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmCaixa = new frmMain();
            frmCaixa.Show();
        }
    }
}
