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
            button9 = new Button();
            button7 = new Button();
            button6 = new Button();
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
            PnlLateral.Controls.Add(button9);
            PnlLateral.Controls.Add(button7);
            PnlLateral.Controls.Add(button6);
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
            // button9
            // 
            button9.Location = new Point(3, 101);
            button9.Name = "button9";
            button9.Size = new Size(43, 43);
            button9.TabIndex = 15;
            button9.Text = "Ger 3";
            button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(3, 52);
            button7.Name = "button7";
            button7.Size = new Size(43, 43);
            button7.TabIndex = 14;
            button7.Text = "Ger 2";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(43, 43);
            button6.TabIndex = 13;
            button6.Text = "Ger 1";
            button6.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 758);
            Controls.Add(PnlPrincipal);
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
        private Button button7;
        private Button button6;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}