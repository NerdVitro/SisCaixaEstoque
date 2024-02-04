namespace SisCaixaEstoque.Formularios
{
    partial class FrmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProduto));
            label4 = new Label();
            TxbNome = new TextBox();
            PnlDados.SuspendLayout();
            SuspendLayout();
            // 
            // PnlDados
            // 
            PnlDados.Controls.Add(label4);
            PnlDados.Controls.Add(TxbNome);
            PnlDados.Size = new Size(591, 323);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 8);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 15;
            label4.Text = "Nome";
            // 
            // TxbNome
            // 
            TxbNome.Location = new Point(8, 24);
            TxbNome.Name = "TxbNome";
            TxbNome.Size = new Size(571, 23);
            TxbNome.TabIndex = 14;
            // 
            // FrmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 323);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCadastroProduto";
            Text = "Cadastro Produto";
            PnlDados.ResumeLayout(false);
            PnlDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private TextBox TxbNome;
    }
}