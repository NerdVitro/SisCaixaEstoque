namespace SisCaixaEstoque.Formularios.Gerenciadores
{
    partial class FrmGerenciarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciarEstoque));
            BtnPesquisarFornecedor = new Button();
            label2 = new Label();
            TxbFornecedor = new TextBox();
            BtnPesquisarProduto = new Button();
            label1 = new Label();
            TxbProduto = new TextBox();
            PnlFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // PnlFiltros
            // 
            PnlFiltros.Controls.Add(BtnPesquisarFornecedor);
            PnlFiltros.Controls.Add(label2);
            PnlFiltros.Controls.Add(TxbFornecedor);
            PnlFiltros.Controls.Add(BtnPesquisarProduto);
            PnlFiltros.Controls.Add(label1);
            PnlFiltros.Controls.Add(TxbProduto);
            PnlFiltros.Size = new Size(733, 105);
            PnlFiltros.Controls.SetChildIndex(TxbProduto, 0);
            PnlFiltros.Controls.SetChildIndex(label1, 0);
            PnlFiltros.Controls.SetChildIndex(BtnPesquisarProduto, 0);
            PnlFiltros.Controls.SetChildIndex(TxbFornecedor, 0);
            PnlFiltros.Controls.SetChildIndex(label2, 0);
            PnlFiltros.Controls.SetChildIndex(BtnPesquisarFornecedor, 0);
            // 
            // BtnPesquisarFornecedor
            // 
            BtnPesquisarFornecedor.FlatAppearance.BorderSize = 0;
            BtnPesquisarFornecedor.FlatStyle = FlatStyle.Flat;
            BtnPesquisarFornecedor.Image = (Image)resources.GetObject("BtnPesquisarFornecedor.Image");
            BtnPesquisarFornecedor.Location = new Point(553, 69);
            BtnPesquisarFornecedor.Name = "BtnPesquisarFornecedor";
            BtnPesquisarFornecedor.Size = new Size(23, 23);
            BtnPesquisarFornecedor.TabIndex = 22;
            BtnPesquisarFornecedor.UseVisualStyleBackColor = true;
            BtnPesquisarFornecedor.Click += BtnPesquisarFornecedor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 52);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 21;
            label2.Text = "Fornecedor";
            // 
            // TxbFornecedor
            // 
            TxbFornecedor.Location = new Point(5, 70);
            TxbFornecedor.Name = "TxbFornecedor";
            TxbFornecedor.Size = new Size(542, 23);
            TxbFornecedor.TabIndex = 20;
            // 
            // BtnPesquisarProduto
            // 
            BtnPesquisarProduto.FlatAppearance.BorderSize = 0;
            BtnPesquisarProduto.FlatStyle = FlatStyle.Flat;
            BtnPesquisarProduto.Image = (Image)resources.GetObject("BtnPesquisarProduto.Image");
            BtnPesquisarProduto.Location = new Point(553, 25);
            BtnPesquisarProduto.Name = "BtnPesquisarProduto";
            BtnPesquisarProduto.Size = new Size(23, 23);
            BtnPesquisarProduto.TabIndex = 19;
            BtnPesquisarProduto.UseVisualStyleBackColor = true;
            BtnPesquisarProduto.Click += BtnPesquisarProduto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 18;
            label1.Text = "Produto";
            // 
            // TxbProduto
            // 
            TxbProduto.Location = new Point(5, 26);
            TxbProduto.Name = "TxbProduto";
            TxbProduto.Size = new Size(542, 23);
            TxbProduto.TabIndex = 17;
            // 
            // FrmGerenciarEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmGerenciarEstoque";
            Text = "Gerenciador de Estoque";
            PnlFiltros.ResumeLayout(false);
            PnlFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnPesquisarFornecedor;
        private Label label2;
        private TextBox TxbFornecedor;
        private Button BtnPesquisarProduto;
        private Label label1;
        private TextBox TxbProduto;
    }
}