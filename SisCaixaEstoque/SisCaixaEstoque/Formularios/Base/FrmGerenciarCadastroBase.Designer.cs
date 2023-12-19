namespace SisCaixaEstoque.Formularios.Base
{
    partial class FrmGerenciarCadastroBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciarCadastroBase));
            PnlLateral = new Panel();
            BtnAdicionar = new Button();
            BtnSair = new Button();
            button1 = new Button();
            button2 = new Button();
            PnlDados = new Panel();
            PnlFiltros = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            BtnConsultar = new Button();
            PnlLateral.SuspendLayout();
            PnlDados.SuspendLayout();
            PnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PnlLateral
            // 
            PnlLateral.BorderStyle = BorderStyle.FixedSingle;
            PnlLateral.Controls.Add(button2);
            PnlLateral.Controls.Add(button1);
            PnlLateral.Controls.Add(BtnAdicionar);
            PnlLateral.Controls.Add(BtnSair);
            PnlLateral.Dock = DockStyle.Left;
            PnlLateral.Location = new Point(0, 0);
            PnlLateral.Name = "PnlLateral";
            PnlLateral.Size = new Size(67, 450);
            PnlLateral.TabIndex = 1;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.FlatStyle = FlatStyle.Flat;
            BtnAdicionar.Image = (Image)resources.GetObject("BtnAdicionar.Image");
            BtnAdicionar.Location = new Point(12, 12);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(43, 43);
            BtnAdicionar.TabIndex = 20;
            BtnAdicionar.UseVisualStyleBackColor = true;
            // 
            // BtnSair
            // 
            BtnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Image = (Image)resources.GetObject("BtnSair.Image");
            BtnSair.Location = new Point(12, 741);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(43, 43);
            BtnSair.TabIndex = 19;
            BtnSair.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 393);
            button1.Name = "button1";
            button1.Size = new Size(43, 43);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(12, 61);
            button2.Name = "button2";
            button2.Size = new Size(43, 43);
            button2.TabIndex = 22;
            button2.UseVisualStyleBackColor = true;
            // 
            // PnlDados
            // 
            PnlDados.Controls.Add(dataGridView1);
            PnlDados.Controls.Add(PnlFiltros);
            PnlDados.Dock = DockStyle.Fill;
            PnlDados.Location = new Point(67, 0);
            PnlDados.Name = "PnlDados";
            PnlDados.Size = new Size(733, 450);
            PnlDados.TabIndex = 2;
            // 
            // PnlFiltros
            // 
            PnlFiltros.Controls.Add(panel1);
            PnlFiltros.Dock = DockStyle.Top;
            PnlFiltros.Location = new Point(0, 0);
            PnlFiltros.Name = "PnlFiltros";
            PnlFiltros.Size = new Size(733, 152);
            PnlFiltros.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 152);
            dataGridView1.Margin = new Padding(10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(733, 298);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnConsultar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(632, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(101, 152);
            panel1.TabIndex = 0;
            // 
            // BtnConsultar
            // 
            BtnConsultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnConsultar.FlatStyle = FlatStyle.Flat;
            BtnConsultar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConsultar.Image = (Image)resources.GetObject("BtnConsultar.Image");
            BtnConsultar.Location = new Point(3, 101);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(93, 46);
            BtnConsultar.TabIndex = 39;
            BtnConsultar.Text = "Filtrar";
            BtnConsultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // FrmGerenciarCadastroBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PnlDados);
            Controls.Add(PnlLateral);
            Name = "FrmGerenciarCadastroBase";
            Text = "FrmGerenciarCadastroBase";
            PnlLateral.ResumeLayout(false);
            PnlDados.ResumeLayout(false);
            PnlFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlLateral;
        private Button BtnAdicionar;
        private Button BtnSair;
        private Button button1;
        private Button button2;
        private Panel PnlDados;
        private Panel PnlFiltros;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button BtnConsultar;
    }
}