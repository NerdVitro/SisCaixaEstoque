namespace SisCaixaEstoque.Formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            PnlPrincipal = new Panel();
            PnlTrabalho = new Panel();
            BtnFinalizar = new Button();
            GrpProduto = new GroupBox();
            label3 = new Label();
            DgvProdutosVenda = new DataGridView();
            label2 = new Label();
            BtnPesquisarProduto = new Button();
            textBox2 = new TextBox();
            BtnAdicinarProduto = new Button();
            BtnPesquisarCliente = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            PnlLateral = new Panel();
            button10 = new Button();
            button8 = new Button();
            BtnEstoque = new Button();
            BtnCliente = new Button();
            BtnCaixa = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            PnlPrincipal.Size = new Size(584, 758);
            PnlPrincipal.TabIndex = 1;
            // 
            // PnlTrabalho
            // 
            PnlTrabalho.Controls.Add(label6);
            PnlTrabalho.Controls.Add(label5);
            PnlTrabalho.Controls.Add(label4);
            PnlTrabalho.Controls.Add(BtnFinalizar);
            PnlTrabalho.Controls.Add(GrpProduto);
            PnlTrabalho.Controls.Add(BtnPesquisarCliente);
            PnlTrabalho.Controls.Add(label1);
            PnlTrabalho.Controls.Add(textBox1);
            PnlTrabalho.Dock = DockStyle.Fill;
            PnlTrabalho.Location = new Point(53, 0);
            PnlTrabalho.Name = "PnlTrabalho";
            PnlTrabalho.Size = new Size(531, 758);
            PnlTrabalho.TabIndex = 1;
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
            GrpProduto.Controls.Add(DgvProdutosVenda);
            GrpProduto.Controls.Add(label2);
            GrpProduto.Controls.Add(BtnPesquisarProduto);
            GrpProduto.Controls.Add(textBox2);
            GrpProduto.Controls.Add(BtnAdicinarProduto);
            GrpProduto.Location = new Point(6, 76);
            GrpProduto.Name = "GrpProduto";
            GrpProduto.Size = new Size(510, 603);
            GrpProduto.TabIndex = 11;
            GrpProduto.TabStop = false;
            GrpProduto.Text = "Produto";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(241, 555);
            label3.Name = "label3";
            label3.Size = new Size(263, 37);
            label3.TabIndex = 10;
            label3.Text = "R$ 100,00";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DgvProdutosVenda
            // 
            DgvProdutosVenda.AllowUserToAddRows = false;
            DgvProdutosVenda.AllowUserToDeleteRows = false;
            DgvProdutosVenda.AllowUserToResizeColumns = false;
            DgvProdutosVenda.AllowUserToResizeRows = false;
            DgvProdutosVenda.BackgroundColor = SystemColors.ButtonFace;
            DgvProdutosVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProdutosVenda.Location = new Point(6, 79);
            DgvProdutosVenda.MultiSelect = false;
            DgvProdutosVenda.Name = "DgvProdutosVenda";
            DgvProdutosVenda.ReadOnly = true;
            DgvProdutosVenda.RowHeadersVisible = false;
            DgvProdutosVenda.RowTemplate.Height = 25;
            DgvProdutosVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProdutosVenda.ShowCellErrors = false;
            DgvProdutosVenda.Size = new Size(498, 473);
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
            BtnPesquisarProduto.FlatStyle = FlatStyle.Flat;
            BtnPesquisarProduto.Location = new Point(429, 50);
            BtnPesquisarProduto.Name = "BtnPesquisarProduto";
            BtnPesquisarProduto.Size = new Size(75, 23);
            BtnPesquisarProduto.TabIndex = 9;
            BtnPesquisarProduto.Text = "Pesquisar";
            BtnPesquisarProduto.UseVisualStyleBackColor = true;
            BtnPesquisarProduto.Click += BtnPesquisarProduto_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(498, 23);
            textBox2.TabIndex = 5;
            // 
            // BtnAdicinarProduto
            // 
            BtnAdicinarProduto.FlatStyle = FlatStyle.Flat;
            BtnAdicinarProduto.Location = new Point(6, 50);
            BtnAdicinarProduto.Name = "BtnAdicinarProduto";
            BtnAdicinarProduto.Size = new Size(75, 23);
            BtnAdicinarProduto.TabIndex = 7;
            BtnAdicinarProduto.Text = "Adicionar";
            BtnAdicinarProduto.UseVisualStyleBackColor = true;
            BtnAdicinarProduto.Click += BtnAdicinarProduto_Click;
            // 
            // BtnPesquisarCliente
            // 
            BtnPesquisarCliente.FlatStyle = FlatStyle.Flat;
            BtnPesquisarCliente.Location = new Point(441, 37);
            BtnPesquisarCliente.Name = "BtnPesquisarCliente";
            BtnPesquisarCliente.Size = new Size(75, 23);
            BtnPesquisarCliente.TabIndex = 10;
            BtnPesquisarCliente.Text = "Pesquisar";
            BtnPesquisarCliente.UseVisualStyleBackColor = true;
            BtnPesquisarCliente.Click += BtnPesquisarCliente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(429, 23);
            textBox1.TabIndex = 1;
            // 
            // PnlLateral
            // 
            PnlLateral.BorderStyle = BorderStyle.FixedSingle;
            PnlLateral.Controls.Add(button10);
            PnlLateral.Controls.Add(button8);
            PnlLateral.Controls.Add(BtnEstoque);
            PnlLateral.Controls.Add(BtnCliente);
            PnlLateral.Controls.Add(BtnCaixa);
            PnlLateral.Dock = DockStyle.Left;
            PnlLateral.Location = new Point(0, 0);
            PnlLateral.Name = "PnlLateral";
            PnlLateral.Size = new Size(53, 758);
            PnlLateral.TabIndex = 0;
            // 
            // button10
            // 
            button10.Location = new Point(3, 199);
            button10.Name = "button10";
            button10.Size = new Size(43, 43);
            button10.TabIndex = 17;
            button10.Text = "Ger 5";
            button10.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(3, 150);
            button8.Name = "button8";
            button8.Size = new Size(43, 43);
            button8.TabIndex = 16;
            button8.Text = "Ger 4";
            button8.UseVisualStyleBackColor = true;
            // 
            // BtnEstoque
            // 
            BtnEstoque.Location = new Point(3, 101);
            BtnEstoque.Name = "BtnEstoque";
            BtnEstoque.Size = new Size(43, 43);
            BtnEstoque.TabIndex = 15;
            BtnEstoque.Text = "Ger 3";
            BtnEstoque.UseVisualStyleBackColor = true;
            // 
            // BtnCliente
            // 
            BtnCliente.Location = new Point(3, 52);
            BtnCliente.Name = "BtnCliente";
            BtnCliente.Size = new Size(43, 43);
            BtnCliente.TabIndex = 14;
            BtnCliente.Text = "Ger 2";
            BtnCliente.UseVisualStyleBackColor = true;
            // 
            // BtnCaixa
            // 
            BtnCaixa.Location = new Point(3, 3);
            BtnCaixa.Name = "BtnCaixa";
            BtnCaixa.Size = new Size(43, 43);
            BtnCaixa.TabIndex = 13;
            BtnCaixa.Text = "Ger 1";
            BtnCaixa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 685);
            label4.Name = "label4";
            label4.Size = new Size(270, 37);
            label4.TabIndex = 23;
            label4.Text = "Caixa Pendente: Vitor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(28, 709);
            label5.Name = "label5";
            label5.Size = new Size(259, 37);
            label5.TabIndex = 24;
            label5.Text = "Caixa Fechado: Vitor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(61, 731);
            label6.Name = "label6";
            label6.Size = new Size(240, 37);
            label6.TabIndex = 25;
            label6.Text = "Caixa Aberto: Vitor";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(584, 758);
            Controls.Add(PnlPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
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
        private Label label3;
        private DataGridView DgvProdutosVenda;
        private Label label2;
        private Button BtnPesquisarProduto;
        private TextBox textBox2;
        private Button BtnAdicinarProduto;
        private Button BtnPesquisarCliente;
        private Label label1;
        private TextBox textBox1;
        private Panel PnlLateral;
        private Button BtnCliente;
        private Button BtnCaixa;
        private Button button8;
        private Button BtnEstoque;
        private Button button10;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}