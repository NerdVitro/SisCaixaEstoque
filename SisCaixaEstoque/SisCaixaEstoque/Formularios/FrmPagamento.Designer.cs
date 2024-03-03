namespace SisCaixaEstoque.Formularios
{
    partial class FrmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagamento));
            BtnFinalizar = new Button();
            BtnConsultaFormaPagamento = new Button();
            TxbFormaPagamento = new TextBox();
            BtnAdicionarFormaPagamento = new Button();
            label1 = new Label();
            LblValorCompra = new Label();
            label2 = new Label();
            DgvPagamento = new DataGridView();
            TxbValorPago = new TextBox();
            label4 = new Label();
            LblTotalPago = new Label();
            groupBox1 = new GroupBox();
            DgvProdutosVenda = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvPagamento).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProdutosVenda).BeginInit();
            SuspendLayout();
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.FlatStyle = FlatStyle.Flat;
            BtnFinalizar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFinalizar.Location = new Point(823, 467);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(137, 61);
            BtnFinalizar.TabIndex = 30;
            BtnFinalizar.Text = "Finalizar";
            BtnFinalizar.UseVisualStyleBackColor = true;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // BtnConsultaFormaPagamento
            // 
            BtnConsultaFormaPagamento.FlatAppearance.BorderSize = 0;
            BtnConsultaFormaPagamento.FlatStyle = FlatStyle.Flat;
            BtnConsultaFormaPagamento.Image = (Image)resources.GetObject("BtnConsultaFormaPagamento.Image");
            BtnConsultaFormaPagamento.Location = new Point(937, 95);
            BtnConsultaFormaPagamento.Name = "BtnConsultaFormaPagamento";
            BtnConsultaFormaPagamento.Size = new Size(23, 23);
            BtnConsultaFormaPagamento.TabIndex = 29;
            BtnConsultaFormaPagamento.UseVisualStyleBackColor = true;
            BtnConsultaFormaPagamento.Click += BtnConsultaFormaPagamento_Click;
            // 
            // TxbFormaPagamento
            // 
            TxbFormaPagamento.Enabled = false;
            TxbFormaPagamento.Location = new Point(543, 95);
            TxbFormaPagamento.Name = "TxbFormaPagamento";
            TxbFormaPagamento.Size = new Size(388, 23);
            TxbFormaPagamento.TabIndex = 26;
            // 
            // BtnAdicionarFormaPagamento
            // 
            BtnAdicionarFormaPagamento.FlatStyle = FlatStyle.Flat;
            BtnAdicionarFormaPagamento.Image = (Image)resources.GetObject("BtnAdicionarFormaPagamento.Image");
            BtnAdicionarFormaPagamento.Location = new Point(649, 134);
            BtnAdicionarFormaPagamento.Name = "BtnAdicionarFormaPagamento";
            BtnAdicionarFormaPagamento.Size = new Size(30, 30);
            BtnAdicionarFormaPagamento.TabIndex = 27;
            BtnAdicionarFormaPagamento.UseVisualStyleBackColor = true;
            BtnAdicionarFormaPagamento.Click += BtnAdicionarFormaPagamento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(543, 77);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 24;
            label1.Text = "Forma Pagamento";
            // 
            // LblValorCompra
            // 
            LblValorCompra.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblValorCompra.Location = new Point(724, 9);
            LblValorCompra.Name = "LblValorCompra";
            LblValorCompra.Size = new Size(236, 37);
            LblValorCompra.TabIndex = 23;
            LblValorCompra.Text = "R$ 100,00";
            LblValorCompra.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(543, 9);
            label2.Name = "label2";
            label2.Size = new Size(186, 37);
            label2.TabIndex = 22;
            label2.Text = "Valor Compra:";
            // 
            // DgvPagamento
            // 
            DgvPagamento.AllowUserToAddRows = false;
            DgvPagamento.AllowUserToDeleteRows = false;
            DgvPagamento.AllowUserToResizeColumns = false;
            DgvPagamento.AllowUserToResizeRows = false;
            DgvPagamento.BackgroundColor = SystemColors.ButtonFace;
            DgvPagamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPagamento.Location = new Point(543, 175);
            DgvPagamento.MultiSelect = false;
            DgvPagamento.Name = "DgvPagamento";
            DgvPagamento.ReadOnly = true;
            DgvPagamento.RowHeadersVisible = false;
            DgvPagamento.RowTemplate.Height = 25;
            DgvPagamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPagamento.ShowCellErrors = false;
            DgvPagamento.Size = new Size(417, 284);
            DgvPagamento.TabIndex = 31;
            DgvPagamento.CellContentClick += DgvPagamento_CellContentClick;
            // 
            // TxbValorPago
            // 
            TxbValorPago.Location = new Point(543, 139);
            TxbValorPago.Name = "TxbValorPago";
            TxbValorPago.PlaceholderText = "00,00";
            TxbValorPago.Size = new Size(100, 23);
            TxbValorPago.TabIndex = 32;
            TxbValorPago.TextAlign = HorizontalAlignment.Right;
            TxbValorPago.KeyPress += TxbValorPago_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 122);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 33;
            label4.Text = "Valor Pago";
            // 
            // LblTotalPago
            // 
            LblTotalPago.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblTotalPago.Location = new Point(543, 479);
            LblTotalPago.Name = "LblTotalPago";
            LblTotalPago.Size = new Size(274, 37);
            LblTotalPago.TabIndex = 35;
            LblTotalPago.Text = "R$ 100,00";
            LblTotalPago.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(DgvProdutosVenda);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 531);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Carrinho de compras";
            // 
            // DgvProdutosVenda
            // 
            DgvProdutosVenda.AllowUserToAddRows = false;
            DgvProdutosVenda.AllowUserToDeleteRows = false;
            DgvProdutosVenda.AllowUserToResizeColumns = false;
            DgvProdutosVenda.AllowUserToResizeRows = false;
            DgvProdutosVenda.BackgroundColor = SystemColors.ButtonFace;
            DgvProdutosVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProdutosVenda.Location = new Point(6, 22);
            DgvProdutosVenda.MultiSelect = false;
            DgvProdutosVenda.Name = "DgvProdutosVenda";
            DgvProdutosVenda.ReadOnly = true;
            DgvProdutosVenda.RowHeadersVisible = false;
            DgvProdutosVenda.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvProdutosVenda.RowTemplate.Height = 25;
            DgvProdutosVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProdutosVenda.ShowCellErrors = false;
            DgvProdutosVenda.Size = new Size(498, 503);
            DgvProdutosVenda.TabIndex = 1;
            // 
            // FrmPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 555);
            Controls.Add(groupBox1);
            Controls.Add(LblTotalPago);
            Controls.Add(label4);
            Controls.Add(TxbValorPago);
            Controls.Add(DgvPagamento);
            Controls.Add(BtnFinalizar);
            Controls.Add(BtnConsultaFormaPagamento);
            Controls.Add(TxbFormaPagamento);
            Controls.Add(BtnAdicionarFormaPagamento);
            Controls.Add(label1);
            Controls.Add(LblValorCompra);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPagamento";
            Text = "Tela de Pagamento";
            ((System.ComponentModel.ISupportInitialize)DgvPagamento).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvProdutosVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnFinalizar;
        private Button BtnConsultaFormaPagamento;
        private TextBox TxbFormaPagamento;
        private Button BtnAdicionarFormaPagamento;
        private Label label1;
        private Label LblValorCompra;
        private Label label2;
        private DataGridView DgvPagamento;
        private TextBox TxbValorPago;
        private Label label4;
        private Label LblTotalPago;
        private GroupBox groupBox1;
        private DataGridView DgvProdutosVenda;
    }
}