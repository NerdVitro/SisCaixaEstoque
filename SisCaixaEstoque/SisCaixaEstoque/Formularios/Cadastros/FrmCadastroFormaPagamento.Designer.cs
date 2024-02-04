namespace SisCaixaEstoque.Formularios
{
    partial class FrmCadastroFormaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFormaPagamento));
            label2 = new Label();
            CbbTipoPagamento = new ComboBox();
            label1 = new Label();
            TxbValorTaxa = new TextBox();
            PnlDados.SuspendLayout();
            SuspendLayout();
            // 
            // PnlDados
            // 
            PnlDados.Controls.Add(label2);
            PnlDados.Controls.Add(CbbTipoPagamento);
            PnlDados.Controls.Add(label1);
            PnlDados.Controls.Add(TxbValorTaxa);
            PnlDados.Size = new Size(591, 323);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 26);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 7;
            label2.Text = "Tipo Pagamento";
            // 
            // CbbTipoPagamento
            // 
            CbbTipoPagamento.AllowDrop = true;
            CbbTipoPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            CbbTipoPagamento.FormattingEnabled = true;
            CbbTipoPagamento.Location = new Point(17, 44);
            CbbTipoPagamento.Name = "CbbTipoPagamento";
            CbbTipoPagamento.Size = new Size(165, 23);
            CbbTipoPagamento.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 27);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 5;
            label1.Text = "Valor Taxa";
            // 
            // TxbValorTaxa
            // 
            TxbValorTaxa.Location = new Point(221, 45);
            TxbValorTaxa.Name = "TxbValorTaxa";
            TxbValorTaxa.PlaceholderText = "00,00";
            TxbValorTaxa.Size = new Size(100, 23);
            TxbValorTaxa.TabIndex = 4;
            TxbValorTaxa.TextAlign = HorizontalAlignment.Right;
            TxbValorTaxa.KeyPress += TxbValorTaxa_KeyPress;
            // 
            // FrmCadastroFormaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 323);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadastroFormaPagamento";
            Text = "Cadastro Forma Pagamento";
            PnlDados.ResumeLayout(false);
            PnlDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private ComboBox CbbTipoPagamento;
        private Label label1;
        private TextBox TxbValorTaxa;
    }
}