namespace SisCaixaEstoque.Formularios
{
    partial class FrmCadastroEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEstoque));
            BtnPesquisarProduto = new Button();
            label1 = new Label();
            TxbProduto = new TextBox();
            BtnPesquisarFornecedor = new Button();
            label2 = new Label();
            TxbFornecedor = new TextBox();
            label5 = new Label();
            TxbCodigo = new TextBox();
            label3 = new Label();
            TxbLote = new TextBox();
            label4 = new Label();
            TxbValorCompra = new TextBox();
            label6 = new Label();
            TxbValorVenda = new TextBox();
            label7 = new Label();
            TxbQuantidade = new TextBox();
            PnlDados.SuspendLayout();
            SuspendLayout();
            // 
            // PnlDados
            // 
            PnlDados.Controls.Add(label7);
            PnlDados.Controls.Add(TxbQuantidade);
            PnlDados.Controls.Add(label6);
            PnlDados.Controls.Add(TxbValorVenda);
            PnlDados.Controls.Add(label4);
            PnlDados.Controls.Add(TxbValorCompra);
            PnlDados.Controls.Add(label3);
            PnlDados.Controls.Add(TxbLote);
            PnlDados.Controls.Add(label5);
            PnlDados.Controls.Add(TxbCodigo);
            PnlDados.Controls.Add(BtnPesquisarFornecedor);
            PnlDados.Controls.Add(label2);
            PnlDados.Controls.Add(TxbFornecedor);
            PnlDados.Controls.Add(BtnPesquisarProduto);
            PnlDados.Controls.Add(label1);
            PnlDados.Controls.Add(TxbProduto);
            PnlDados.Size = new Size(591, 323);
            // 
            // BtnPesquisarProduto
            // 
            BtnPesquisarProduto.FlatAppearance.BorderSize = 0;
            BtnPesquisarProduto.FlatStyle = FlatStyle.Flat;
            BtnPesquisarProduto.Image = (Image)resources.GetObject("BtnPesquisarProduto.Image");
            BtnPesquisarProduto.Location = new Point(556, 23);
            BtnPesquisarProduto.Name = "BtnPesquisarProduto";
            BtnPesquisarProduto.Size = new Size(23, 23);
            BtnPesquisarProduto.TabIndex = 13;
            BtnPesquisarProduto.UseVisualStyleBackColor = true;
            BtnPesquisarProduto.Click += BtnPesquisarProduto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 6);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 12;
            label1.Text = "Produto";
            // 
            // TxbProduto
            // 
            TxbProduto.Location = new Point(8, 24);
            TxbProduto.Name = "TxbProduto";
            TxbProduto.Size = new Size(542, 23);
            TxbProduto.TabIndex = 11;
            // 
            // BtnPesquisarFornecedor
            // 
            BtnPesquisarFornecedor.FlatAppearance.BorderSize = 0;
            BtnPesquisarFornecedor.FlatStyle = FlatStyle.Flat;
            BtnPesquisarFornecedor.Image = (Image)resources.GetObject("BtnPesquisarFornecedor.Image");
            BtnPesquisarFornecedor.Location = new Point(556, 67);
            BtnPesquisarFornecedor.Name = "BtnPesquisarFornecedor";
            BtnPesquisarFornecedor.Size = new Size(23, 23);
            BtnPesquisarFornecedor.TabIndex = 16;
            BtnPesquisarFornecedor.UseVisualStyleBackColor = true;
            BtnPesquisarFornecedor.Click += BtnPesquisarFornecedor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 50);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 15;
            label2.Text = "Fornecedor";
            // 
            // TxbFornecedor
            // 
            TxbFornecedor.Location = new Point(8, 68);
            TxbFornecedor.Name = "TxbFornecedor";
            TxbFornecedor.Size = new Size(542, 23);
            TxbFornecedor.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 93);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 18;
            label5.Text = "Código";
            // 
            // TxbCodigo
            // 
            TxbCodigo.Location = new Point(149, 111);
            TxbCodigo.Name = "TxbCodigo";
            TxbCodigo.PlaceholderText = "0";
            TxbCodigo.Size = new Size(124, 23);
            TxbCodigo.TabIndex = 17;
            TxbCodigo.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 137);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 20;
            label3.Text = "Lote";
            // 
            // TxbLote
            // 
            TxbLote.Location = new Point(149, 155);
            TxbLote.Name = "TxbLote";
            TxbLote.PlaceholderText = "0";
            TxbLote.Size = new Size(124, 23);
            TxbLote.TabIndex = 19;
            TxbLote.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 93);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 22;
            label4.Text = "Valor Compra";
            // 
            // TxbValorCompra
            // 
            TxbValorCompra.Location = new Point(8, 111);
            TxbValorCompra.Name = "TxbValorCompra";
            TxbValorCompra.PlaceholderText = "00,00";
            TxbValorCompra.Size = new Size(135, 23);
            TxbValorCompra.TabIndex = 21;
            TxbValorCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 137);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 24;
            label6.Text = "Valor Venda";
            // 
            // TxbValorVenda
            // 
            TxbValorVenda.Location = new Point(8, 155);
            TxbValorVenda.Name = "TxbValorVenda";
            TxbValorVenda.PlaceholderText = "00,00";
            TxbValorVenda.Size = new Size(135, 23);
            TxbValorVenda.TabIndex = 23;
            TxbValorVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 181);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 26;
            label7.Text = "Quantidade";
            // 
            // TxbQuantidade
            // 
            TxbQuantidade.Location = new Point(8, 199);
            TxbQuantidade.Name = "TxbQuantidade";
            TxbQuantidade.PlaceholderText = "0";
            TxbQuantidade.Size = new Size(135, 23);
            TxbQuantidade.TabIndex = 25;
            TxbQuantidade.TextAlign = HorizontalAlignment.Right;
            // 
            // FrmCadastroEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 323);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCadastroEstoque";
            Text = "Cadastro Estoque";
            PnlDados.ResumeLayout(false);
            PnlDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnPesquisarProduto;
        private Label label1;
        private TextBox TxbProduto;
        private Button BtnPesquisarFornecedor;
        private Label label2;
        private TextBox TxbFornecedor;
        private Label label5;
        private TextBox TxbCodigo;
        private Label label3;
        private TextBox TxbLote;
        private Label label7;
        private TextBox TxbQuantidade;
        private Label label6;
        private TextBox TxbValorVenda;
        private Label label4;
        private TextBox TxbValorCompra;
    }
}