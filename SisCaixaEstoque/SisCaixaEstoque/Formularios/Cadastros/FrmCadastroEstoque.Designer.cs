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
            BtnPesquisarCliente = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            TxbValorTaxa = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            PnlDados.SuspendLayout();
            SuspendLayout();
            // 
            // PnlDados
            // 
            PnlDados.Controls.Add(label7);
            PnlDados.Controls.Add(textBox6);
            PnlDados.Controls.Add(label6);
            PnlDados.Controls.Add(textBox5);
            PnlDados.Controls.Add(label4);
            PnlDados.Controls.Add(TxbValorTaxa);
            PnlDados.Controls.Add(label3);
            PnlDados.Controls.Add(textBox3);
            PnlDados.Controls.Add(label5);
            PnlDados.Controls.Add(textBox4);
            PnlDados.Controls.Add(button1);
            PnlDados.Controls.Add(label2);
            PnlDados.Controls.Add(textBox2);
            PnlDados.Controls.Add(BtnPesquisarCliente);
            PnlDados.Controls.Add(label1);
            PnlDados.Controls.Add(textBox1);
            PnlDados.Size = new Size(591, 323);
            // 
            // BtnPesquisarCliente
            // 
            BtnPesquisarCliente.FlatAppearance.BorderSize = 0;
            BtnPesquisarCliente.FlatStyle = FlatStyle.Flat;
            BtnPesquisarCliente.Image = (Image)resources.GetObject("BtnPesquisarCliente.Image");
            BtnPesquisarCliente.Location = new Point(556, 23);
            BtnPesquisarCliente.Name = "BtnPesquisarCliente";
            BtnPesquisarCliente.Size = new Size(23, 23);
            BtnPesquisarCliente.TabIndex = 13;
            BtnPesquisarCliente.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(8, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(542, 23);
            textBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(556, 67);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 16;
            button1.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            textBox2.Location = new Point(8, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(542, 23);
            textBox2.TabIndex = 14;
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
            // textBox4
            // 
            textBox4.Location = new Point(149, 111);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "0";
            textBox4.Size = new Size(124, 23);
            textBox4.TabIndex = 17;
            textBox4.TextAlign = HorizontalAlignment.Right;
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
            // textBox3
            // 
            textBox3.Location = new Point(149, 155);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "0";
            textBox3.Size = new Size(124, 23);
            textBox3.TabIndex = 19;
            textBox3.TextAlign = HorizontalAlignment.Right;
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
            // TxbValorTaxa
            // 
            TxbValorTaxa.Location = new Point(8, 111);
            TxbValorTaxa.Name = "TxbValorTaxa";
            TxbValorTaxa.PlaceholderText = "00,00";
            TxbValorTaxa.Size = new Size(135, 23);
            TxbValorTaxa.TabIndex = 21;
            TxbValorTaxa.TextAlign = HorizontalAlignment.Right;
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
            // textBox5
            // 
            textBox5.Location = new Point(8, 155);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "00,00";
            textBox5.Size = new Size(135, 23);
            textBox5.TabIndex = 23;
            textBox5.TextAlign = HorizontalAlignment.Right;
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
            // textBox6
            // 
            textBox6.Location = new Point(8, 199);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "0";
            textBox6.Size = new Size(135, 23);
            textBox6.TabIndex = 25;
            textBox6.TextAlign = HorizontalAlignment.Right;
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

        private Button BtnPesquisarCliente;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label4;
        private TextBox TxbValorTaxa;
    }
}