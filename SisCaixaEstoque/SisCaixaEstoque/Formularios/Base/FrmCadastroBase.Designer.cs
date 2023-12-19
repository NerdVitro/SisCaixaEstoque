namespace SisCaixaEstoque.Formularios.Base
{
    partial class FrmCadastroBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroBase));
            PnlLateral = new Panel();
            BtnSalvar = new Button();
            BtnSair = new Button();
            PnlDados = new Panel();
            PnlLateral.SuspendLayout();
            SuspendLayout();
            // 
            // PnlLateral
            // 
            PnlLateral.Controls.Add(BtnSalvar);
            PnlLateral.Controls.Add(BtnSair);
            PnlLateral.Dock = DockStyle.Left;
            PnlLateral.Location = new Point(0, 0);
            PnlLateral.Name = "PnlLateral";
            PnlLateral.Size = new Size(67, 450);
            PnlLateral.TabIndex = 0;
            // 
            // BtnSalvar
            // 
            BtnSalvar.FlatStyle = FlatStyle.Flat;
            BtnSalvar.Image = (Image)resources.GetObject("BtnSalvar.Image");
            BtnSalvar.Location = new Point(12, 12);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(43, 43);
            BtnSalvar.TabIndex = 20;
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnSair
            // 
            BtnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Image = (Image)resources.GetObject("BtnSair.Image");
            BtnSair.Location = new Point(12, 395);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(43, 43);
            BtnSair.TabIndex = 19;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // PnlDados
            // 
            PnlDados.Dock = DockStyle.Fill;
            PnlDados.Location = new Point(67, 0);
            PnlDados.Name = "PnlDados";
            PnlDados.Size = new Size(733, 450);
            PnlDados.TabIndex = 1;
            // 
            // FrmCadastroBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PnlDados);
            Controls.Add(PnlLateral);
            Name = "FrmCadastroBase";
            Text = "FrmCadastroBase";
            PnlLateral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlLateral;
        public Panel PnlDados;
        private Button BtnSair;
        private Button BtnSalvar;
    }
}