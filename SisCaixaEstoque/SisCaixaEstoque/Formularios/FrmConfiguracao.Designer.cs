namespace SisCaixaEstoque.Formularios
{
    partial class FrmConfiguracao
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracao));
            BtnFuncionario = new Button();
            ToolTipMensagens = new ToolTip(components);
            SuspendLayout();
            // 
            // BtnFuncionario
            // 
            BtnFuncionario.FlatStyle = FlatStyle.Flat;
            BtnFuncionario.Image = (Image)resources.GetObject("BtnFuncionario.Image");
            BtnFuncionario.Location = new Point(12, 12);
            BtnFuncionario.Name = "BtnFuncionario";
            BtnFuncionario.Size = new Size(57, 56);
            BtnFuncionario.TabIndex = 18;
            BtnFuncionario.UseVisualStyleBackColor = true;
            BtnFuncionario.Click += BtnFuncionario_Click;
            // 
            // FrmConfiguracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnFuncionario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmConfiguracao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuração";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnFuncionario;
        private ToolTip ToolTipMensagens;
    }
}