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
            comboBox1 = new ComboBox();
            label1 = new Label();
            TxbValorTaxa = new TextBox();
            PnlDados.SuspendLayout();
            SuspendLayout();
            // 
            // PnlDados
            // 
            PnlDados.Controls.Add(label2);
            PnlDados.Controls.Add(comboBox1);
            PnlDados.Controls.Add(label1);
            PnlDados.Controls.Add(TxbValorTaxa);
            PnlDados.Size = new Size(326, 171);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dinheiro", "Cartão de Débito", "Cartão de Crédito" });
            comboBox1.Location = new Point(17, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 26);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 5;
            label1.Text = "Valor Taxa";
            // 
            // TxbValorTaxa
            // 
            TxbValorTaxa.Location = new Point(163, 44);
            TxbValorTaxa.Name = "TxbValorTaxa";
            TxbValorTaxa.PlaceholderText = "00,00";
            TxbValorTaxa.Size = new Size(100, 23);
            TxbValorTaxa.TabIndex = 4;
            TxbValorTaxa.TextAlign = HorizontalAlignment.Right;
            // 
            // FrmCadastroFormaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 171);
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
        private ComboBox comboBox1;
        private Label label1;
        private TextBox TxbValorTaxa;
    }
}