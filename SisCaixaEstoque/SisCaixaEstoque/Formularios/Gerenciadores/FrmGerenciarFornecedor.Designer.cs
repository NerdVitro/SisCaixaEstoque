namespace SisCaixaEstoque.Formularios.Gerenciadores
{
    partial class FrmGerenciarFornecedor
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
            label1 = new Label();
            TxbCliente = new TextBox();
            PnlFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // PnlFiltros
            // 
            PnlFiltros.Controls.Add(label1);
            PnlFiltros.Controls.Add(TxbCliente);
            PnlFiltros.Size = new Size(733, 56);
            PnlFiltros.Controls.SetChildIndex(TxbCliente, 0);
            PnlFiltros.Controls.SetChildIndex(label1, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "Fornecedor";
            // 
            // TxbCliente
            // 
            TxbCliente.Location = new Point(8, 24);
            TxbCliente.Name = "TxbCliente";
            TxbCliente.Size = new Size(618, 23);
            TxbCliente.TabIndex = 5;
            // 
            // FrmGerenciadFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmGerenciadFornecedor";
            Text = "Gerenciador de Fornecedor";
            PnlFiltros.ResumeLayout(false);
            PnlFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox TxbCliente;
    }
}