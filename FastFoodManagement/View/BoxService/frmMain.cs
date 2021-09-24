using FastFoodManagement.View.BoxService.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FastFoodManagement.View.BoxService.Components.Widget;

namespace FastFoodManagement.View.BoxService
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Evento Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        #endregion

        #region Método add item configurando as propriedades
        public void AddItem(string name, double cost, categorias category, string icon) // Método para adicionar itens
        {
            flowLayoutPanelLanches.Controls.Add(new Widget()
            {
                Title = name,
                Cost = cost,
                Category = category,
                Icon = Image.FromFile("ImageFoods/" + icon)
            });
        }
        #endregion

        #region Itens de que serão exibidos (Evento Shown)
        private void frmMain_Shown(object sender, EventArgs e) // Evento shown, ocorre sempre que um formulário é mostrado pela primeira vez
        {
            
            // Lanches
            AddItem("Burguer", 19.90, categorias.Lanche, "hamburguer1.png");

            // Sobremesa
            AddItem("Sorvete", 6.90, categorias.Sobremesa, "sorvetecremoso.png");

            // Bebida
            AddItem("Coca-cola", 3.90, categorias.Bebida, "refricoca.png");
            

            // Bebida Alcoolica
            AddItem("Heineken", 4.90, categorias.BebidaAlcoolica, "hamburguer1.png");
        }
        #endregion

        #region Barra de pesquisa
        private void txbPesquisa_TextChanged(object sender, EventArgs e) // Barra de pesquisa
        {
            foreach (var item in flowLayoutPanelLanches.Controls)
            {
                var wdg = (Widget)item;
                wdg.Visible = wdg.lblTitle.Text.ToLower().ToLower().Contains(txbPesquisa.Text.Trim().ToLower());
            }
        }
        #endregion

        #region Evento de click na barra de pesquisa (para sumir o texto - estilo PlaceHolder)
        private void txbPesquisa_Click(object sender, EventArgs e)
        {
            txbPesquisa.Clear();
        }
        #endregion
    }
}
