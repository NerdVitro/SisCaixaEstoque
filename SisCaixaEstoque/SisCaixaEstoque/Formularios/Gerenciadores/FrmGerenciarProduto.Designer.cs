namespace SisCaixaEstoque.Formularios.Gerenciadores
{
    partial class FrmGerenciarProduto
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
            label1 = new Label();
            TxbProduto = new TextBox();
            label2 = new Label();
            TxbLote = new TextBox();
            PnlFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // PnlFiltros
            // 
            PnlFiltros.Controls.Add(label2);
            PnlFiltros.Controls.Add(TxbLote);
            PnlFiltros.Controls.Add(label1);
            PnlFiltros.Controls.Add(TxbProduto);
            PnlFiltros.Size = new Size(733, 56);
            PnlFiltros.Controls.SetChildIndex(TxbProduto, 0);
            PnlFiltros.Controls.SetChildIndex(label1, 0);
            PnlFiltros.Controls.SetChildIndex(TxbLote, 0);
            PnlFiltros.Controls.SetChildIndex(label2, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 8;
            label1.Text = "Produto";
            // 
            // TxbProduto
            // 
            TxbProduto.Location = new Point(8, 24);
            TxbProduto.Name = "TxbProduto";
            TxbProduto.Size = new Size(423, 23);
            TxbProduto.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 6);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 10;
            label2.Text = "Lote";
            label2.Visible = false;
            // 
            // TxbLote
            // 
            TxbLote.Location = new Point(437, 24);
            TxbLote.Name = "TxbLote";
            TxbLote.Size = new Size(189, 23);
            TxbLote.TabIndex = 9;
            TxbLote.Visible = false;
            // 
            // FrmGerenciarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmGerenciarProduto";
            Text = "Gerenciador de Produto";
            PnlFiltros.ResumeLayout(false);
            PnlFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox TxbProduto;
        private Label label2;
        private TextBox TxbLote;
    }
}