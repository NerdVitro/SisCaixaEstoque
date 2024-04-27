namespace SisCaixaEstoque.Formularios.Base
{
    partial class FrmRelatorioBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioBase));
            PnlLateral = new Panel();
            BtnExportarPlanilha = new Button();
            BtnAbrirRelatorio = new Button();
            BtnFechar = new Button();
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
            PnlLateral.Controls.Add(BtnExportarPlanilha);
            PnlLateral.Controls.Add(BtnAbrirRelatorio);
            PnlLateral.Controls.Add(BtnFechar);
            PnlLateral.Dock = DockStyle.Left;
            PnlLateral.Location = new Point(0, 0);
            PnlLateral.Name = "PnlLateral";
            PnlLateral.Size = new Size(58, 390);
            PnlLateral.TabIndex = 2;
            // 
            // BtnExportarPlanilha
            // 
            BtnExportarPlanilha.FlatStyle = FlatStyle.Flat;
            BtnExportarPlanilha.Image = (Image)resources.GetObject("BtnExportarPlanilha.Image");
            BtnExportarPlanilha.Location = new Point(10, 53);
            BtnExportarPlanilha.Name = "BtnExportarPlanilha";
            BtnExportarPlanilha.Size = new Size(37, 37);
            BtnExportarPlanilha.TabIndex = 23;
            BtnExportarPlanilha.UseVisualStyleBackColor = true;
            BtnExportarPlanilha.Click += BtnExportarPlanilha_Click;
            // 
            // BtnAbrirRelatorio
            // 
            BtnAbrirRelatorio.FlatStyle = FlatStyle.Flat;
            BtnAbrirRelatorio.Image = (Image)resources.GetObject("BtnAbrirRelatorio.Image");
            BtnAbrirRelatorio.Location = new Point(10, 10);
            BtnAbrirRelatorio.Name = "BtnAbrirRelatorio";
            BtnAbrirRelatorio.Size = new Size(37, 37);
            BtnAbrirRelatorio.TabIndex = 22;
            BtnAbrirRelatorio.UseVisualStyleBackColor = true;
            BtnAbrirRelatorio.Click += BtnAbrirRelatorio_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnFechar.FlatStyle = FlatStyle.Flat;
            BtnFechar.Image = (Image)resources.GetObject("BtnFechar.Image");
            BtnFechar.Location = new Point(10, 341);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(37, 37);
            BtnFechar.TabIndex = 21;
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // PnlDados
            // 
            PnlDados.Controls.Add(DgvDados);
            PnlDados.Controls.Add(PnlFiltros);
            PnlDados.Dock = DockStyle.Fill;
            PnlDados.Location = new Point(58, 0);
            PnlDados.Name = "PnlDados";
            PnlDados.Size = new Size(628, 390);
            PnlDados.TabIndex = 5;
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
            DgvDados.Location = new Point(0, 91);
            DgvDados.MultiSelect = false;
            DgvDados.Name = "DgvDados";
            DgvDados.ReadOnly = true;
            DgvDados.RowHeadersVisible = false;
            DgvDados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvDados.RowTemplate.Height = 25;
            DgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDados.ShowCellErrors = false;
            DgvDados.Size = new Size(628, 299);
            DgvDados.TabIndex = 6;
            // 
            // PnlFiltros
            // 
            PnlFiltros.Controls.Add(panel1);
            PnlFiltros.Dock = DockStyle.Top;
            PnlFiltros.Location = new Point(0, 0);
            PnlFiltros.MinimumSize = new Size(0, 49);
            PnlFiltros.Name = "PnlFiltros";
            PnlFiltros.Size = new Size(628, 91);
            PnlFiltros.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnFiltrar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(521, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(107, 91);
            panel1.TabIndex = 0;
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnFiltrar.FlatStyle = FlatStyle.Flat;
            BtnFiltrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFiltrar.Image = (Image)resources.GetObject("BtnFiltrar.Image");
            BtnFiltrar.Location = new Point(3, 44);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(99, 40);
            BtnFiltrar.TabIndex = 40;
            BtnFiltrar.Text = "Filtrar";
            BtnFiltrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFiltrar.UseVisualStyleBackColor = true;
            // 
            // FrmRelatorioBase
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 390);
            Controls.Add(PnlDados);
            Controls.Add(PnlLateral);
            Name = "FrmRelatorioBase";
            Text = "FrmRelatorioBase";
            Shown += FrmRelatorioBase_Shown;
            PnlLateral.ResumeLayout(false);
            PnlDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDados).EndInit();
            PnlFiltros.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel PnlLateral;
        public DataGridView DgvDados;
        public Panel PnlFiltros;
        public Button BtnFiltrar;
        public Button BtnAbrirRelatorio;
        public Button BtnFechar;
        public Button BtnExportarPlanilha;
        public Panel PnlDados;
        public Panel panel1;
    }
}