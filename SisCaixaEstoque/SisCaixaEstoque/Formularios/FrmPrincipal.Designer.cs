﻿namespace SisCaixaEstoque.Formularios
{
    partial class FrmPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            PnlPrincipal = new Panel();
            PnlTrabalho = new Panel();
            label4 = new Label();
            BtnFinalizar = new Button();
            GrpProduto = new GroupBox();
            label3 = new Label();
            TxbQuantidade = new TextBox();
            LblTotalVenda = new Label();
            DgvProdutosVenda = new DataGridView();
            label2 = new Label();
            BtnPesquisarProduto = new Button();
            TxbProduto = new TextBox();
            BtnAdicinarProduto = new Button();
            BtnPesquisarCliente = new Button();
            label1 = new Label();
            TxbCliente = new TextBox();
            PnlLateral = new Panel();
            BtnRelatorios = new Button();
            BtnSair = new Button();
            BtnConfiguracao = new Button();
            BtnEstoque = new Button();
            BtnProduto = new Button();
            BtnCliente = new Button();
            BtnCaixa = new Button();
            ToolTipMensagens = new ToolTip(components);
            PnlPrincipal.SuspendLayout();
            PnlTrabalho.SuspendLayout();
            GrpProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProdutosVenda).BeginInit();
            PnlLateral.SuspendLayout();
            SuspendLayout();
            // 
            // PnlPrincipal
            // 
            PnlPrincipal.Controls.Add(PnlTrabalho);
            PnlPrincipal.Controls.Add(PnlLateral);
            PnlPrincipal.Dock = DockStyle.Fill;
            PnlPrincipal.Location = new Point(0, 0);
            PnlPrincipal.Name = "PnlPrincipal";
            PnlPrincipal.Size = new Size(580, 758);
            PnlPrincipal.TabIndex = 1;
            // 
            // PnlTrabalho
            // 
            PnlTrabalho.Controls.Add(label4);
            PnlTrabalho.Controls.Add(BtnFinalizar);
            PnlTrabalho.Controls.Add(GrpProduto);
            PnlTrabalho.Controls.Add(BtnPesquisarCliente);
            PnlTrabalho.Controls.Add(label1);
            PnlTrabalho.Controls.Add(TxbCliente);
            PnlTrabalho.Dock = DockStyle.Fill;
            PnlTrabalho.Location = new Point(53, 0);
            PnlTrabalho.Name = "PnlTrabalho";
            PnlTrabalho.Size = new Size(527, 758);
            PnlTrabalho.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 697);
            label4.Name = "label4";
            label4.Size = new Size(270, 37);
            label4.TabIndex = 23;
            label4.Text = "Caixa Pendente: Vitor";
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.FlatStyle = FlatStyle.Flat;
            BtnFinalizar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFinalizar.Location = new Point(379, 685);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(137, 61);
            BtnFinalizar.TabIndex = 12;
            BtnFinalizar.Text = "Finalizar";
            BtnFinalizar.UseVisualStyleBackColor = true;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // GrpProduto
            // 
            GrpProduto.Controls.Add(label3);
            GrpProduto.Controls.Add(TxbQuantidade);
            GrpProduto.Controls.Add(LblTotalVenda);
            GrpProduto.Controls.Add(DgvProdutosVenda);
            GrpProduto.Controls.Add(label2);
            GrpProduto.Controls.Add(BtnPesquisarProduto);
            GrpProduto.Controls.Add(TxbProduto);
            GrpProduto.Controls.Add(BtnAdicinarProduto);
            GrpProduto.ForeColor = Color.Black;
            GrpProduto.Location = new Point(6, 76);
            GrpProduto.Name = "GrpProduto";
            GrpProduto.Size = new Size(510, 603);
            GrpProduto.TabIndex = 11;
            GrpProduto.TabStop = false;
            GrpProduto.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 54);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 12;
            label3.Text = "Quantidade do Produto";
            // 
            // TxbQuantidade
            // 
            TxbQuantidade.Location = new Point(326, 75);
            TxbQuantidade.Name = "TxbQuantidade";
            TxbQuantidade.Size = new Size(132, 23);
            TxbQuantidade.TabIndex = 11;
            TxbQuantidade.TextAlign = HorizontalAlignment.Right;
            TxbQuantidade.KeyPress += TxbQuantidade_KeyPress;
            // 
            // LblTotalVenda
            // 
            LblTotalVenda.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblTotalVenda.Location = new Point(241, 555);
            LblTotalVenda.Name = "LblTotalVenda";
            LblTotalVenda.Size = new Size(263, 37);
            LblTotalVenda.TabIndex = 10;
            LblTotalVenda.Text = "R$ 100,00";
            LblTotalVenda.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DgvProdutosVenda
            // 
            DgvProdutosVenda.AllowUserToAddRows = false;
            DgvProdutosVenda.AllowUserToDeleteRows = false;
            DgvProdutosVenda.AllowUserToResizeColumns = false;
            DgvProdutosVenda.AllowUserToResizeRows = false;
            DgvProdutosVenda.BackgroundColor = SystemColors.ButtonFace;
            DgvProdutosVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProdutosVenda.Location = new Point(6, 109);
            DgvProdutosVenda.MultiSelect = false;
            DgvProdutosVenda.Name = "DgvProdutosVenda";
            DgvProdutosVenda.ReadOnly = true;
            DgvProdutosVenda.RowHeadersVisible = false;
            DgvProdutosVenda.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvProdutosVenda.RowTemplate.Height = 25;
            DgvProdutosVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProdutosVenda.ShowCellErrors = false;
            DgvProdutosVenda.Size = new Size(498, 443);
            DgvProdutosVenda.TabIndex = 0;
            DgvProdutosVenda.CellContentClick += DgvProdutosVenda_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 555);
            label2.Name = "label2";
            label2.Size = new Size(229, 37);
            label2.TabIndex = 4;
            label2.Text = "Valor Total Venda:";
            // 
            // BtnPesquisarProduto
            // 
            BtnPesquisarProduto.FlatAppearance.BorderSize = 0;
            BtnPesquisarProduto.FlatStyle = FlatStyle.Flat;
            BtnPesquisarProduto.Image = (Image)resources.GetObject("BtnPesquisarProduto.Image");
            BtnPesquisarProduto.Location = new Point(481, 21);
            BtnPesquisarProduto.Name = "BtnPesquisarProduto";
            BtnPesquisarProduto.Size = new Size(23, 23);
            BtnPesquisarProduto.TabIndex = 9;
            BtnPesquisarProduto.UseVisualStyleBackColor = true;
            BtnPesquisarProduto.Click += BtnPesquisarProduto_Click;
            // 
            // TxbProduto
            // 
            TxbProduto.Enabled = false;
            TxbProduto.Location = new Point(6, 21);
            TxbProduto.Name = "TxbProduto";
            TxbProduto.Size = new Size(469, 23);
            TxbProduto.TabIndex = 5;
            // 
            // BtnAdicinarProduto
            // 
            BtnAdicinarProduto.FlatStyle = FlatStyle.Flat;
            BtnAdicinarProduto.Image = (Image)resources.GetObject("BtnAdicinarProduto.Image");
            BtnAdicinarProduto.Location = new Point(474, 68);
            BtnAdicinarProduto.Name = "BtnAdicinarProduto";
            BtnAdicinarProduto.Size = new Size(30, 30);
            BtnAdicinarProduto.TabIndex = 7;
            BtnAdicinarProduto.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnAdicinarProduto.UseVisualStyleBackColor = true;
            BtnAdicinarProduto.Click += BtnAdicinarProduto_Click;
            // 
            // BtnPesquisarCliente
            // 
            BtnPesquisarCliente.FlatAppearance.BorderSize = 0;
            BtnPesquisarCliente.FlatStyle = FlatStyle.Flat;
            BtnPesquisarCliente.Image = (Image)resources.GetObject("BtnPesquisarCliente.Image");
            BtnPesquisarCliente.Location = new Point(487, 37);
            BtnPesquisarCliente.Name = "BtnPesquisarCliente";
            BtnPesquisarCliente.Size = new Size(23, 23);
            BtnPesquisarCliente.TabIndex = 10;
            BtnPesquisarCliente.UseVisualStyleBackColor = true;
            BtnPesquisarCliente.Click += BtnPesquisarCliente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Cliente";
            // 
            // TxbCliente
            // 
            TxbCliente.Enabled = false;
            TxbCliente.Location = new Point(12, 37);
            TxbCliente.Name = "TxbCliente";
            TxbCliente.Size = new Size(469, 23);
            TxbCliente.TabIndex = 1;
            // 
            // PnlLateral
            // 
            PnlLateral.BorderStyle = BorderStyle.FixedSingle;
            PnlLateral.Controls.Add(BtnRelatorios);
            PnlLateral.Controls.Add(BtnSair);
            PnlLateral.Controls.Add(BtnConfiguracao);
            PnlLateral.Controls.Add(BtnEstoque);
            PnlLateral.Controls.Add(BtnProduto);
            PnlLateral.Controls.Add(BtnCliente);
            PnlLateral.Controls.Add(BtnCaixa);
            PnlLateral.Dock = DockStyle.Left;
            PnlLateral.Location = new Point(0, 0);
            PnlLateral.Name = "PnlLateral";
            PnlLateral.Size = new Size(53, 758);
            PnlLateral.TabIndex = 0;
            // 
            // BtnRelatorios
            // 
            BtnRelatorios.FlatStyle = FlatStyle.Flat;
            BtnRelatorios.Image = (Image)resources.GetObject("BtnRelatorios.Image");
            BtnRelatorios.Location = new Point(3, 199);
            BtnRelatorios.Name = "BtnRelatorios";
            BtnRelatorios.Size = new Size(43, 43);
            BtnRelatorios.TabIndex = 19;
            BtnRelatorios.UseVisualStyleBackColor = true;
            BtnRelatorios.Click += BtnRelatorios_Click;
            // 
            // BtnSair
            // 
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Image = (Image)resources.GetObject("BtnSair.Image");
            BtnSair.Location = new Point(3, 708);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(43, 43);
            BtnSair.TabIndex = 18;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnConfiguracao
            // 
            BtnConfiguracao.FlatStyle = FlatStyle.Flat;
            BtnConfiguracao.Image = (Image)resources.GetObject("BtnConfiguracao.Image");
            BtnConfiguracao.Location = new Point(3, 248);
            BtnConfiguracao.Name = "BtnConfiguracao";
            BtnConfiguracao.Size = new Size(43, 43);
            BtnConfiguracao.TabIndex = 17;
            BtnConfiguracao.UseVisualStyleBackColor = true;
            BtnConfiguracao.Click += BtnConfiguracao_Click;
            // 
            // BtnEstoque
            // 
            BtnEstoque.FlatStyle = FlatStyle.Flat;
            BtnEstoque.Image = (Image)resources.GetObject("BtnEstoque.Image");
            BtnEstoque.Location = new Point(3, 150);
            BtnEstoque.Name = "BtnEstoque";
            BtnEstoque.Size = new Size(43, 43);
            BtnEstoque.TabIndex = 16;
            BtnEstoque.UseVisualStyleBackColor = true;
            BtnEstoque.Click += BtnEstoque_Click;
            // 
            // BtnProduto
            // 
            BtnProduto.FlatStyle = FlatStyle.Flat;
            BtnProduto.Image = (Image)resources.GetObject("BtnProduto.Image");
            BtnProduto.Location = new Point(3, 101);
            BtnProduto.Name = "BtnProduto";
            BtnProduto.Size = new Size(43, 43);
            BtnProduto.TabIndex = 15;
            BtnProduto.UseVisualStyleBackColor = true;
            BtnProduto.Click += BtnProduto_Click;
            // 
            // BtnCliente
            // 
            BtnCliente.FlatStyle = FlatStyle.Flat;
            BtnCliente.Image = (Image)resources.GetObject("BtnCliente.Image");
            BtnCliente.Location = new Point(3, 52);
            BtnCliente.Name = "BtnCliente";
            BtnCliente.Size = new Size(43, 43);
            BtnCliente.TabIndex = 14;
            BtnCliente.UseVisualStyleBackColor = true;
            BtnCliente.Click += BtnCliente_Click;
            // 
            // BtnCaixa
            // 
            BtnCaixa.FlatStyle = FlatStyle.Flat;
            BtnCaixa.Image = (Image)resources.GetObject("BtnCaixa.Image");
            BtnCaixa.Location = new Point(3, 3);
            BtnCaixa.Name = "BtnCaixa";
            BtnCaixa.Size = new Size(43, 43);
            BtnCaixa.TabIndex = 13;
            BtnCaixa.UseVisualStyleBackColor = true;
            BtnCaixa.Click += BtnCaixa_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(580, 758);
            Controls.Add(PnlPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            FormClosed += FrmPrincipal_FormClosed;
            PnlPrincipal.ResumeLayout(false);
            PnlTrabalho.ResumeLayout(false);
            PnlTrabalho.PerformLayout();
            GrpProduto.ResumeLayout(false);
            GrpProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProdutosVenda).EndInit();
            PnlLateral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlPrincipal;
        private Panel PnlTrabalho;
        private Button BtnFinalizar;
        private GroupBox GrpProduto;
        private Label LblTotalVenda;
        private DataGridView DgvProdutosVenda;
        private Label label2;
        private Button BtnPesquisarProduto;
        private TextBox TxbProduto;
        private Button BtnAdicinarProduto;
        private Button BtnPesquisarCliente;
        private Label label1;
        private TextBox TxbCliente;
        private Panel PnlLateral;
        private Button BtnCliente;
        private Button BtnCaixa;
        private Button BtnEstoque;
        private Button BtnProduto;
        private Button BtnConfiguracao;
        private Label label4;
        private Button BtnSair;
        private ToolTip ToolTipMensagens;
        private Button BtnRelatorios;
        private TextBox TxbQuantidade;
        private Label label3;
    }
}