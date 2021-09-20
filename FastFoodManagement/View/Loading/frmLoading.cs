using FastFoodManagement.View.SystemOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodManagement
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        #region Método para deixar o fundo degrade
        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);

            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(6, 13, 19), Color.FromArgb(0, 51, 102), 45);
            graphics.FillRectangle(br, gradient_rect);
        }
        #endregion

        #region Evento Paint do Panel
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }
        #endregion

        #region Codificação do tempo do loading no evento Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            panelBarProgressLoading.Width += 3;
            if(panelBarProgressLoading.Width >= 699)
            {
                timer1.Stop();
                frmSystemOptions frmOption = new frmSystemOptions();
                frmOption.Show();
                this.Hide();
            }
        }
        #endregion
    }
}
