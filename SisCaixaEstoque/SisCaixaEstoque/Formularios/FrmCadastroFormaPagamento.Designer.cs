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
            TxbValorTaxa = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // TxbValorTaxa
            // 
            TxbValorTaxa.Location = new Point(178, 52);
            TxbValorTaxa.Name = "TxbValorTaxa";
            TxbValorTaxa.PlaceholderText = "00,00";
            TxbValorTaxa.Size = new Size(100, 23);
            TxbValorTaxa.TabIndex = 0;
            TxbValorTaxa.TextAlign = HorizontalAlignment.Right;
            TxbValorTaxa.KeyPress += TxbValorTaxa_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dinheiro", "Cartão de Débito", "Cartão de Crédito" });
            comboBox1.Location = new Point(32, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 34);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Valor Taxa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 34);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 3;
            label2.Text = "Tipo Pagamento";
            // 
            // FrmCadastroFormaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 112);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(TxbValorTaxa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadastroFormaPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Forma Pagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxbValorTaxa;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
    }
}