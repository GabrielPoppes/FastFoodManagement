
namespace FastFoodManagement.View.SystemOptions
{
    partial class frmSystemOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelfrmSystemOptions = new System.Windows.Forms.Panel();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureCaixa = new System.Windows.Forms.PictureBox();
            this.picturePedidos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelfrmSystemOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelfrmSystemOptions
            // 
            this.panelfrmSystemOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.panelfrmSystemOptions.Controls.Add(this.panel1);
            this.panelfrmSystemOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelfrmSystemOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(13)))), ((int)(((byte)(19)))));
            this.panelfrmSystemOptions.Location = new System.Drawing.Point(0, 0);
            this.panelfrmSystemOptions.Name = "panelfrmSystemOptions";
            this.panelfrmSystemOptions.Size = new System.Drawing.Size(408, 348);
            this.panelfrmSystemOptions.TabIndex = 0;
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCaixa.Location = new System.Drawing.Point(68, 281);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(111, 44);
            this.btnCaixa.TabIndex = 1;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.Location = new System.Drawing.Point(247, 281);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(111, 44);
            this.btnPedidos.TabIndex = 0;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureCaixa);
            this.panel1.Controls.Add(this.picturePedidos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Controls.Add(this.btnCaixa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 348);
            this.panel1.TabIndex = 4;
            // 
            // pictureCaixa
            // 
            this.pictureCaixa.Image = global::FastFoodManagement.Properties.Resources.boxPic;
            this.pictureCaixa.Location = new System.Drawing.Point(54, 153);
            this.pictureCaixa.Name = "pictureCaixa";
            this.pictureCaixa.Size = new System.Drawing.Size(149, 122);
            this.pictureCaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCaixa.TabIndex = 5;
            this.pictureCaixa.TabStop = false;
            this.pictureCaixa.Click += new System.EventHandler(this.pictureCaixa_Click);
            // 
            // picturePedidos
            // 
            this.picturePedidos.Image = global::FastFoodManagement.Properties.Resources.pedidos;
            this.picturePedidos.Location = new System.Drawing.Point(227, 153);
            this.picturePedidos.Name = "picturePedidos";
            this.picturePedidos.Size = new System.Drawing.Size(149, 122);
            this.picturePedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePedidos.TabIndex = 4;
            this.picturePedidos.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FastFoodManagement.Properties.Resources.GERENCIADORLOGO;
            this.pictureBox1.Location = new System.Drawing.Point(8, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmSystemOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 348);
            this.Controls.Add(this.panelfrmSystemOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSystemOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções de setores";
            this.panelfrmSystemOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelfrmSystemOptions;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picturePedidos;
        private System.Windows.Forms.PictureBox pictureCaixa;
    }
}