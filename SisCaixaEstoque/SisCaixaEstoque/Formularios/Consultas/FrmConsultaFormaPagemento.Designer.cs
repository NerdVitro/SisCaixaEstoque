namespace SisCaixaEstoque.Formularios.Consultas
{
    partial class FrmConsultaFormaPagemento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaFormaPagemento));
            DgvPagamento = new DataGridView();
            BtnConsultar = new Button();
            TxbFormaPagamento = new TextBox();
            LblFormaPagamento = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvPagamento).BeginInit();
            SuspendLayout();
            // 
            // DgvPagamento
            // 
            DgvPagamento.AllowUserToAddRows = false;
            DgvPagamento.AllowUserToDeleteRows = false;
            DgvPagamento.AllowUserToResizeColumns = false;
            DgvPagamento.AllowUserToResizeRows = false;
            DgvPagamento.BackgroundColor = SystemColors.ButtonFace;
            DgvPagamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPagamento.Location = new Point(12, 56);
            DgvPagamento.MultiSelect = false;
            DgvPagamento.Name = "DgvPagamento";
            DgvPagamento.ReadOnly = true;
            DgvPagamento.RowHeadersVisible = false;
            DgvPagamento.RowTemplate.Height = 25;
            DgvPagamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPagamento.ShowCellErrors = false;
            DgvPagamento.Size = new Size(417, 289);
            DgvPagamento.TabIndex = 32;
            DgvPagamento.CellContentClick += DgvPagamento_CellContentClick;
            // 
            // BtnConsultar
            // 
            BtnConsultar.FlatStyle = FlatStyle.Flat;
            BtnConsultar.Image = (Image)resources.GetObject("BtnConsultar.Image");
            BtnConsultar.Location = new Point(406, 27);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(23, 23);
            BtnConsultar.TabIndex = 35;
            BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // TxbFormaPagamento
            // 
            TxbFormaPagamento.Location = new Point(12, 27);
            TxbFormaPagamento.Name = "TxbFormaPagamento";
            TxbFormaPagamento.Size = new Size(388, 23);
            TxbFormaPagamento.TabIndex = 34;
            // 
            // LblFormaPagamento
            // 
            LblFormaPagamento.AutoSize = true;
            LblFormaPagamento.Location = new Point(12, 9);
            LblFormaPagamento.Name = "LblFormaPagamento";
            LblFormaPagamento.Size = new Size(105, 15);
            LblFormaPagamento.TabIndex = 33;
            LblFormaPagamento.Text = "Forma Pagamento";
            // 
            // FrmConsultaFormaPagemento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 357);
            Controls.Add(BtnConsultar);
            Controls.Add(TxbFormaPagamento);
            Controls.Add(LblFormaPagamento);
            Controls.Add(DgvPagamento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(454, 396);
            MinimizeBox = false;
            MinimumSize = new Size(454, 396);
            Name = "FrmConsultaFormaPagemento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Forma Pagamento";
            ((System.ComponentModel.ISupportInitialize)DgvPagamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvPagamento;
        private Button BtnConsultar;
        private TextBox TxbFormaPagamento;
        private Label LblFormaPagamento;
    }
}