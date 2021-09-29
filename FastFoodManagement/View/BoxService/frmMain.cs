using FastFoodManagement.DAL;
using FastFoodManagement.View.BoxService.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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
            var w = new Widget()
            {
                Title = name,
                Cost = cost,
                Category = category,
                Icon = Image.FromFile("ImageFoods/" + icon)
            };

            flowLayoutPanelLanches.Controls.Add(w);
            w.OnSelect += (ss, ee) =>
            {
                var wdg = (Widget)ss;
                foreach (DataGridViewRow item in gridCost.Rows) // gridCost = noma da grid
                {
                    if (item.Cells[0].Value.ToString() == wdg.lblTitle.Text)
                    {
                        item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
                        item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * double.Parse(wdg.lblCost.Text.Replace("R$",""))).ToString("C2");
                        CalcularTotal();
                        return;
                    }
                }
                gridCost.Rows.Add(new object[] { wdg.lblTitle.Text, 1, wdg.lblCost.Text });
                CalcularTotal();
            };
        }
        #endregion

        #region Método para calcular o total dos produtos selecionados!
        void CalcularTotal()
        {
            double total=0;
            foreach (DataGridViewRow item in gridCost.Rows)
            {
                total += double.Parse(item.Cells[2].Value.ToString().Replace("R$", ""));
            }
            lblTotal.Text = total.ToString("C2");
        }
        #endregion

        #region Itens de que serão exibidos (Evento Shown)
        private void frmMain_Shown(object sender, EventArgs e) // Evento shown, ocorre sempre que um formulário é mostrado pela primeira vez
        {
            ExibirTodosProdutos();
        }
        #endregion

        // Barra de pesquisa
        #region Evento de click na barra de pesquisa (para sumir o texto - estilo PlaceHolder)
        private void txbPesquisa_Click(object sender, EventArgs e)
        {
            txbPesquisa.Clear();
        }
        #endregion

        #region Barra de pesquisa (só pesquisa o item após apertar enter
        private void txbPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || txbPesquisa.Text.Trim().Length == 0)
            {
                foreach (var item in flowLayoutPanelLanches.Controls)
                {
                    var wdg = (Widget)item;
                    wdg.Visible = wdg.lblTitle.Text.ToLower().ToLower().Contains(txbPesquisa.Text.Trim().ToLower());
                }
            }
        }
        #endregion

        #region Ícone da lupa para fazer pesquisa, clicou nele, busca a palavra chave
        private void iconBuscarLupa_Click(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanelLanches.Controls)
            {
                var wdg = (Widget)item;
                wdg.Visible = wdg.lblTitle.Text.ToLower().ToLower().Contains(txbPesquisa.Text.Trim().ToLower());
            }
        }
        #endregion

        // Métodos para exibir os PRODUTOS
        #region Método para exibir todos os produtos
        private void ExibirTodosProdutos()
        {
            flowLayoutPanelLanches.Controls.Clear();
            // Lanches
            AddItem("Hamburgão", 19.90, categorias.Lanche, "hamburguer1.png");
            AddItem("X-Salada", 19.90, categorias.Lanche, "x-saladas.png");
            AddItem("X-Bacon", 19.90, categorias.Lanche, "x-bacon.png");
            AddItem("X-Tudo", 19.90, categorias.Lanche, "x-tudo.png");
            AddItem("X-Egg", 19.90, categorias.Lanche, "x-egg.png");

            // Sobremesa
            AddItem("Sorvete Chocolate", 6.90, categorias.Sobremesa, "sorvetecremoso.png");
            AddItem("Casquinha Mista", 6.90, categorias.Sobremesa, "casquinha-mista.png");
            AddItem("Sorvete Cone", 6.90, categorias.Sobremesa, "sorvete-cone-recheado.png");
            AddItem("Casquinha baunilha", 6.90, categorias.Sobremesa, "casquinha-baunilha.png");
            AddItem("Picolé vegano", 6.90, categorias.Sobremesa, "picole-vegano-chocolate.png");

            // Bebida
            AddItem("Coca-cola lata", 3.90, categorias.Bebida, "refricoca.png");
            AddItem("Fanta Uva lata", 3.90, categorias.Bebida, "fanta-uva.png");
            AddItem("H2O garrafa", 3.90, categorias.Bebida, "refri-H2O.png");
            AddItem("Tubaina garrafa", 3.90, categorias.Bebida, "tubaina.png");
            AddItem("Pepsi lata", 3.90, categorias.Bebida, "pepsi.png");


            // Bebida Alcoolica
            AddItem("Heineken lata", 4.90, categorias.BebidaAlcoolica, "cervejaheinekenlata.png");
            AddItem("Skol lata", 4.90, categorias.BebidaAlcoolica, "skol.png");
            AddItem("Brahma lata", 4.90, categorias.BebidaAlcoolica, "brahma.png");
            AddItem("Itaipava lata", 4.90, categorias.BebidaAlcoolica, "itaipava.png");
            AddItem("Amstel lata", 4.90, categorias.BebidaAlcoolica, "amstel.png");
        }
        #endregion

        #region Método para exibir os lanches
        private void ExibirLanches()
        {
            flowLayoutPanelLanches.Controls.Clear(); // Limpando os controles (produtos) do Flow Panel para recarregar os novos
            // Lanches
            AddItem("Hamburgão", 19.90, categorias.Lanche, "hamburguer1.png");
            AddItem("X-Salada", 19.90, categorias.Lanche, "x-saladas.png");
            AddItem("X-Bacon", 19.90, categorias.Lanche, "x-bacon.png");
            AddItem("X-Tudo", 19.90, categorias.Lanche, "x-tudo.png");
            AddItem("X-Egg", 19.90, categorias.Lanche, "x-egg.png");
        }
        #endregion

        #region Método para exibir as sobremesas
        private void ExibirSobremesas()
        {
            flowLayoutPanelLanches.Controls.Clear();
            // Sobremesa
            AddItem("Sorvete Chocolate", 6.90, categorias.Sobremesa, "sorvetecremoso.png");
            AddItem("Casquinha Mista", 6.90, categorias.Sobremesa, "casquinha-mista.png");
            AddItem("Sorvete Cone", 6.90, categorias.Sobremesa, "sorvete-cone-recheado.png");
            AddItem("Casquinha baunilha", 6.90, categorias.Sobremesa, "casquinha-baunilha.png");
            AddItem("Picolé vegano", 6.90, categorias.Sobremesa, "picole-vegano-chocolate.png");
        }
        #endregion

        #region Método para exibir as bebidas
        private void ExibirBebidas()
        {
            flowLayoutPanelLanches.Controls.Clear();
            // Bebida
            AddItem("Coca-cola lata", 3.90, categorias.Bebida, "refricoca.png");
            AddItem("Fanta Uva lata", 3.90, categorias.Bebida, "fanta-uva.png");
            AddItem("H2O garrafa", 3.90, categorias.Bebida, "refri-H2O.png");
            AddItem("Tubaina garrafa", 3.90, categorias.Bebida, "tubaina.png");
            AddItem("Pepsi lata", 3.90, categorias.Bebida, "pepsi.png");
        }
        #endregion

        #region Método para exibir as bebidas alcoolicas
        private void ExibirBebidasAlcoolicas()
        {
            flowLayoutPanelLanches.Controls.Clear();
            // Bebida Alcoolica
            AddItem("Heineken lata", 4.90, categorias.BebidaAlcoolica, "cervejaheinekenlata.png");
            AddItem("Skol lata", 4.90, categorias.BebidaAlcoolica, "skol.png");
            AddItem("Brahma lata", 4.90, categorias.BebidaAlcoolica, "brahma.png");
            AddItem("Itaipava lata", 4.90, categorias.BebidaAlcoolica, "itaipava.png");
            AddItem("Amstel lata", 4.90, categorias.BebidaAlcoolica, "amstel.png");
        }
        #endregion

        // Botões do MENU
        #region Botão do MENU (Todos os items)
        private void btnTodos_Click(object sender, EventArgs e)
        {
            ExibirTodosProdutos();
        }
        #endregion

        #region Botão do MENU (Lanches)
        private void btnLanche_Click(object sender, EventArgs e)
        {
            ExibirLanches();
        }
        #endregion

        #region Botão do MENU (Sobremesa)
        private void btnSobremesa_Click(object sender, EventArgs e)
        {
            ExibirSobremesas();
        }
        #endregion

        #region Botão do MENU (Bebida)
        private void btnBebida_Click(object sender, EventArgs e)
        {
            ExibirBebidas();
        }
        #endregion

        #region Botão do MENU (Bebida Alcoolica)
        private void btnBebidaAlcoolica_Click(object sender, EventArgs e)
        {
            ExibirBebidasAlcoolicas();
        }

        #endregion

        // Botões do Panel de Custos
        #region Método do botão limpar tudo (todos os itens selecionados)
        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            gridCost.Rows.Clear(); // Limpando todos os itens
            lblTotal.Text = "R$0,00"; // Retornando o total para R$0,00
        }
        #endregion

        #region Método do botão para finalizar o pedido
        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            string total = lblTotal.Text;
            if (total != "R$0,00")
            {
                MessageBox.Show($"Pedido finalizado com sucesso! Total: {total}");

                PrintDialog pd = new PrintDialog();
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += myPrintPage;
                if(pd.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                }
                gridCost.Rows.Clear(); // Limpando todos os itens
                lblTotal.Text = "R$0,00"; // Retornando o total para R$0,00
            }

            else
            {
                MessageBox.Show("Por favor, selecione os itens para finalizar o pedido!");
            }          
            
        }
        #endregion

        #region Método para imprimir a Grid
        private void myPrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.gridCost.Width, this.gridCost.Height);
            gridCost.DrawToBitmap(bm, new Rectangle(0, 0, this.gridCost.Width, this.gridCost.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
        #endregion
    }
}
