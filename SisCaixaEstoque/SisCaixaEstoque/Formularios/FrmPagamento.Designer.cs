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
            button5 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            DgvPagamento = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvPagamento).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(292, 467);
            button5.Name = "button5";
            button5.Size = new Size(137, 61);
            button5.TabIndex = 30;
            button5.Text = "Finalizar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(354, 124);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 29;
            button3.Text = "Pesquisar";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(417, 23);
            textBox2.TabIndex = 26;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 124);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 28;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(93, 124);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 24;
            label1.Text = "Forma Pagamento";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(166, 9);
            label3.Name = "label3";
            label3.Size = new Size(263, 37);
            label3.TabIndex = 23;
            label3.Text = "R$ 100,00";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(148, 37);
            label2.TabIndex = 22;
            label2.Text = "Valor Total:";
            // 
            // DgvPagamento
            // 
            DgvPagamento.AllowUserToAddRows = false;
            DgvPagamento.AllowUserToDeleteRows = false;
            DgvPagamento.AllowUserToResizeColumns = false;
            DgvPagamento.AllowUserToResizeRows = false;
            DgvPagamento.BackgroundColor = SystemColors.ButtonFace;
            DgvPagamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPagamento.Location = new Point(12, 153);
            DgvPagamento.MultiSelect = false;
            DgvPagamento.Name = "DgvPagamento";
            DgvPagamento.ReadOnly = true;
            DgvPagamento.RowHeadersVisible = false;
            DgvPagamento.RowTemplate.Height = 25;
            DgvPagamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPagamento.ShowCellErrors = false;
            DgvPagamento.Size = new Size(417, 306);
            DgvPagamento.TabIndex = 31;
            // 
            // FrmPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 547);
            Controls.Add(DgvPagamento);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FrmPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPagamento";
            ((System.ComponentModel.ISupportInitialize)DgvPagamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button3;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label3;
        private Label label2;
        private DataGridView DgvPagamento;
    }
}