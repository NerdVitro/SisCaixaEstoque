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
            BtnEditar = new Button();
            BtnFechar = new Button();
            BtnAdicionar = new Button();
            BtnSair = new Button();
            PnlDados = new Panel();
            DgvDados = new DataGridView();
            PnlFiltros = new Panel();
            panel1 = new Panel();
            BtnFiltrar = new Button();
            PnlLateral.SuspendLayout();
            PnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDados).BeginInit();
            PnlFiltros.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PnlLateral
            // 
            PnlLateral.BorderStyle = BorderStyle.FixedSingle;
            PnlLateral.Controls.Add(BtnEditar);
            PnlLateral.Controls.Add(BtnFechar);
            PnlLateral.Controls.Add(BtnAdicionar);
            PnlLateral.Controls.Add(BtnSair);
            PnlLateral.Dock = DockStyle.Left;
            PnlLateral.Location = new Point(0, 0);
            PnlLateral.Name = "PnlLateral";
            PnlLateral.Size = new Size(67, 450);
            PnlLateral.TabIndex = 1;
            // 
            // BtnEditar
            // 
            BtnEditar.FlatStyle = FlatStyle.Flat;
            BtnEditar.Image = (Image)resources.GetObject("BtnEditar.Image");
            BtnEditar.Location = new Point(12, 61);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(43, 43);
            BtnEditar.TabIndex = 22;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnFechar.FlatStyle = FlatStyle.Flat;
            BtnFechar.Image = (Image)resources.GetObject("BtnFechar.Image");
            BtnFechar.Location = new Point(12, 393);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(43, 43);
            BtnFechar.TabIndex = 21;
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
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
            BtnAdicionar.Click += BtnAdicionar_Click;
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
            // PnlDados
            // 
            PnlDados.Controls.Add(DgvDados);
            PnlDados.Controls.Add(PnlFiltros);
            PnlDados.Dock = DockStyle.Fill;
            PnlDados.Location = new Point(67, 0);
            PnlDados.Name = "PnlDados";
            PnlDados.Size = new Size(733, 450);
            PnlDados.TabIndex = 2;
            // 
            // DgvDados
            // 
            DgvDados.AllowUserToAddRows = false;
            DgvDados.AllowUserToDeleteRows = false;
            DgvDados.AllowUserToResizeColumns = false;
            DgvDados.AllowUserToResizeRows = false;
            DgvDados.BackgroundColor = SystemColors.ButtonFace;
            DgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDados.Dock = DockStyle.Fill;
            DgvDados.Location = new Point(0, 152);
            DgvDados.MultiSelect = false;
            DgvDados.Name = "DgvDados";
            DgvDados.ReadOnly = true;
            DgvDados.RowHeadersVisible = false;
            DgvDados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvDados.RowTemplate.Height = 25;
            DgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDados.ShowCellErrors = false;
            DgvDados.Size = new Size(733, 298);
            DgvDados.TabIndex = 1;
            // 
            // PnlFiltros
            // 
            PnlFiltros.Controls.Add(panel1);
            PnlFiltros.Dock = DockStyle.Top;
            PnlFiltros.Location = new Point(0, 0);
            PnlFiltros.MinimumSize = new Size(0, 56);
            PnlFiltros.Name = "PnlFiltros";
            PnlFiltros.Size = new Size(733, 152);
            PnlFiltros.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnFiltrar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(632, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(101, 152);
            panel1.TabIndex = 0;
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnFiltrar.FlatStyle = FlatStyle.Flat;
            BtnFiltrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFiltrar.Image = (Image)resources.GetObject("BtnFiltrar.Image");
            BtnFiltrar.Location = new Point(3, 101);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(93, 46);
            BtnFiltrar.TabIndex = 39;
            BtnFiltrar.Text = "Filtrar";
            BtnFiltrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFiltrar.UseVisualStyleBackColor = true;
            BtnFiltrar.Click += BtnFiltrar_Click;
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
            ((System.ComponentModel.ISupportInitialize)DgvDados).EndInit();
            PnlFiltros.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button BtnAdicionar;
        private Button BtnSair;
        private Button BtnFechar;
        private Button BtnEditar;
        private Panel PnlDados;
        private Panel panel1;
        private Button BtnFiltrar;
        public Panel PnlFiltros;
        public DataGridView DgvDados;
        public Panel PnlLateral;
    }
}