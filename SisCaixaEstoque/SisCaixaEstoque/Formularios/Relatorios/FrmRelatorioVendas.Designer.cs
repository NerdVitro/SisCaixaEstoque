﻿namespace SisCaixaEstoque.Formularios.Relatorios
{
    partial class FrmRelatorioVendas
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
            TxbCliente = new TextBox();
            label2 = new Label();
            TxbProduto = new TextBox();
            PnlFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // PnlLateral
            // 
            PnlLateral.Size = new Size(58, 606);
            // 
            // PnlFiltros
            // 
            PnlFiltros.Controls.Add(label2);
            PnlFiltros.Controls.Add(TxbProduto);
            PnlFiltros.Controls.Add(label1);
            PnlFiltros.Controls.Add(TxbCliente);
            PnlFiltros.MinimumSize = new Size(0, 42);
            PnlFiltros.Size = new Size(785, 49);
            PnlFiltros.Controls.SetChildIndex(TxbCliente, 0);
            PnlFiltros.Controls.SetChildIndex(label1, 0);
            PnlFiltros.Controls.SetChildIndex(TxbProduto, 0);
            PnlFiltros.Controls.SetChildIndex(label2, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 10);
            label1.Name = "label1";
            label1.Size = new Size(43, 13);
            label1.TabIndex = 6;
            label1.Text = "Cliente";
            // 
            // TxbCliente
            // 
            TxbCliente.Location = new Point(7, 24);
            TxbCliente.Name = "TxbCliente";
            TxbCliente.Size = new Size(213, 22);
            TxbCliente.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 10);
            label2.Name = "label2";
            label2.Size = new Size(49, 13);
            label2.TabIndex = 8;
            label2.Text = "Produto";
            // 
            // TxbProduto
            // 
            TxbProduto.Location = new Point(229, 24);
            TxbProduto.Name = "TxbProduto";
            TxbProduto.Size = new Size(213, 22);
            TxbProduto.TabIndex = 7;
            // 
            // FrmRelatorioVendas
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 512);
            MinimumSize = new Size(859, 551);
            Name = "FrmRelatorioVendas";
            Text = "Relatórios de Vendas";
            PnlFiltros.ResumeLayout(false);
            PnlFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox TxbCliente;
        private Label label2;
        private TextBox TxbProduto;
    }
}