namespace SisCaixaEstoque.Formularios.Relatorios
{
    partial class FrmRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorios));
            BtnVendas = new Button();
            SuspendLayout();
            // 
            // BtnVendas
            // 
            BtnVendas.FlatStyle = FlatStyle.Flat;
            BtnVendas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVendas.ForeColor = Color.FromArgb(64, 64, 64);
            BtnVendas.Image = (Image)resources.GetObject("BtnVendas.Image");
            BtnVendas.ImageAlign = ContentAlignment.MiddleLeft;
            BtnVendas.Location = new Point(12, 12);
            BtnVendas.Name = "BtnVendas";
            BtnVendas.Size = new Size(227, 56);
            BtnVendas.TabIndex = 19;
            BtnVendas.Text = "Relatórios de Vendas";
            BtnVendas.TextAlign = ContentAlignment.MiddleRight;
            BtnVendas.UseVisualStyleBackColor = true;
            BtnVendas.Click += BtnVendas_Click;
            // 
            // FrmRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 297);
            Controls.Add(BtnVendas);
            Name = "FrmRelatorios";
            Text = "Relatórios";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnVendas;
    }
}