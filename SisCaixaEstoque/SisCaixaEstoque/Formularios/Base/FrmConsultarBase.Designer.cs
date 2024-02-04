namespace SisCaixaEstoque.Formularios.Base
{
    partial class FrmConsultarBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarBase));
            PnlTopo = new Panel();
            PnlFiltros = new Panel();
            PnelLateral = new Panel();
            BtnAdicinar = new Button();
            BtnConsultar = new Button();
            PnlGrid = new Panel();
            DgvDados = new DataGridView();
            PnlTopo.SuspendLayout();
            PnelLateral.SuspendLayout();
            PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDados).BeginInit();
            SuspendLayout();
            // 
            // PnlTopo
            // 
            PnlTopo.Controls.Add(PnlFiltros);
            PnlTopo.Controls.Add(PnelLateral);
            PnlTopo.Dock = DockStyle.Top;
            PnlTopo.Location = new Point(0, 0);
            PnlTopo.Name = "PnlTopo";
            PnlTopo.Size = new Size(518, 92);
            PnlTopo.TabIndex = 0;
            // 
            // PnlFiltros
            // 
            PnlFiltros.Dock = DockStyle.Fill;
            PnlFiltros.Location = new Point(0, 0);
            PnlFiltros.Name = "PnlFiltros";
            PnlFiltros.Size = new Size(441, 92);
            PnlFiltros.TabIndex = 40;
            // 
            // PnelLateral
            // 
            PnelLateral.Controls.Add(BtnAdicinar);
            PnelLateral.Controls.Add(BtnConsultar);
            PnelLateral.Dock = DockStyle.Right;
            PnelLateral.Location = new Point(441, 0);
            PnelLateral.Name = "PnelLateral";
            PnelLateral.Size = new Size(77, 92);
            PnelLateral.TabIndex = 39;
            // 
            // BtnAdicinar
            // 
            BtnAdicinar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAdicinar.FlatStyle = FlatStyle.Flat;
            BtnAdicinar.Image = (Image)resources.GetObject("BtnAdicinar.Image");
            BtnAdicinar.Location = new Point(35, 56);
            BtnAdicinar.Name = "BtnAdicinar";
            BtnAdicinar.Size = new Size(30, 30);
            BtnAdicinar.TabIndex = 39;
            BtnAdicinar.UseVisualStyleBackColor = true;
            BtnAdicinar.Click += BtnAdicinar_Click;
            // 
            // BtnConsultar
            // 
            BtnConsultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnConsultar.FlatAppearance.BorderSize = 0;
            BtnConsultar.FlatStyle = FlatStyle.Flat;
            BtnConsultar.Image = (Image)resources.GetObject("BtnConsultar.Image");
            BtnConsultar.Location = new Point(6, 60);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(23, 23);
            BtnConsultar.TabIndex = 38;
            BtnConsultar.UseVisualStyleBackColor = true;
            BtnConsultar.Click += BtnConsultar_Click;
            // 
            // PnlGrid
            // 
            PnlGrid.Controls.Add(DgvDados);
            PnlGrid.Dock = DockStyle.Fill;
            PnlGrid.Location = new Point(0, 92);
            PnlGrid.Name = "PnlGrid";
            PnlGrid.Padding = new Padding(8);
            PnlGrid.Size = new Size(518, 358);
            PnlGrid.TabIndex = 1;
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
            DgvDados.Location = new Point(8, 8);
            DgvDados.MultiSelect = false;
            DgvDados.Name = "DgvDados";
            DgvDados.ReadOnly = true;
            DgvDados.RowHeadersVisible = false;
            DgvDados.RowTemplate.Height = 25;
            DgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDados.ShowCellErrors = false;
            DgvDados.Size = new Size(502, 342);
            DgvDados.TabIndex = 33;
            DgvDados.CellContentClick += DgvDados_CellContentClick;
            // 
            // FrmConsultarBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 450);
            Controls.Add(PnlGrid);
            Controls.Add(PnlTopo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultarBase";
            Text = "FrmConsultarBase";
            PnlTopo.ResumeLayout(false);
            PnelLateral.ResumeLayout(false);
            PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDados).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel PnlGrid;
        private Button BtnConsultar;
        private Panel PnelLateral;
        private Button BtnAdicinar;
        public Panel PnlFiltros;
        public Panel PnlTopo;
        public DataGridView DgvDados;
    }
}