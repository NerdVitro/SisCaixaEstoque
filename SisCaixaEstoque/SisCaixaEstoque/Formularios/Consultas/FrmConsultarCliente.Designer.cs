namespace SisCaixaEstoque.Formularios.Consultas
{
    partial class FrmConsultarCliente
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
            TxbNome = new TextBox();
            Lbl = new Label();
            PnlFiltros.SuspendLayout();
            PnlTopo.SuspendLayout();
            SuspendLayout();
            // 
            // PnlFiltros
            // 
            PnlFiltros.Controls.Add(Lbl);
            PnlFiltros.Controls.Add(TxbNome);
            PnlFiltros.Size = new Size(520, 55);
            // 
            // PnlTopo
            // 
            PnlTopo.Size = new Size(597, 55);
            // 
            // TxbNome
            // 
            TxbNome.Location = new Point(8, 24);
            TxbNome.Name = "TxbNome";
            TxbNome.Size = new Size(506, 23);
            TxbNome.TabIndex = 0;
            // 
            // Lbl
            // 
            Lbl.AutoSize = true;
            Lbl.Location = new Point(8, 8);
            Lbl.Name = "Lbl";
            Lbl.Size = new Size(40, 15);
            Lbl.TabIndex = 1;
            Lbl.Text = "Nome";
            // 
            // FrmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 531);
            Name = "FrmConsultarCliente";
            Text = "Consulta de Cliente";
            PnlFiltros.ResumeLayout(false);
            PnlFiltros.PerformLayout();
            PnlTopo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxbNome;
        private Label Lbl;
    }
}