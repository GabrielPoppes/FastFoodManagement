using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Adicionei essa biblioteca

namespace FastFoodManagement.View.BoxService.Components
{
    public partial class Widget : UserControl
    {
        #region Arredondando as bordas do Widget
        [DllImportAttribute("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int left,
            int top,
            int right,
            int bottom,
            int width,
            int height
            );
        #endregion

        #region Variável categoria e custo (do item)
        private categorias _category;
        private double _cost;
        #endregion

        public event EventHandler OnSelect = null;

        #region Inicialização da form
        public Widget()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7)); // Arredondando as bordas do Widget
        }
        #endregion

        #region Evento quando clica na imagem do Widget
        private void pictureBox1_Click(object sender, EventArgs e) // Evento quando clica na imagem do hamburguer
        {
            OnSelect?.Invoke(this, e);
        }
        #endregion

        #region Propriedades do Widget
        // Propriedades
        public enum categorias { Lanche, Sobremesa, Bebida, BebidaAlcoolica } // Categorias do MENU
        public categorias Category { get => _category; set => _category = value; }       
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; } // Label Titulo do Widget
        public double Cost { get => _cost; set { _cost = value; lblCost.Text = _cost.ToString("C2"); } } // Label Custo (Valor ($)) do Widget
        public Image Icon { get => pictureBox1.Image; set => pictureBox1.Image = value; } // PictureBox Imagem do lanche do Widget
        #endregion
    }
}
