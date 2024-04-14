﻿namespace SisCaixaEstoque.Formularios.Base
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
            BtnAbrirRelatorio = new Button();
            BtnFechar = new Button();
            PnlFiltros = new Panel();
            panel1 = new Panel();
            BtnFiltrar = new Button();
            DgvDados = new DataGridView();
            BtnExportarPlanilha = new Button();
            PnlLateral.SuspendLayout();
            PnlFiltros.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDados).BeginInit();
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
            PnlLateral.Size = new Size(67, 450);
            PnlLateral.TabIndex = 2;
            // 
            // BtnAbrirRelatorio
            // 
            BtnAbrirRelatorio.FlatStyle = FlatStyle.Flat;
            BtnAbrirRelatorio.Image = (Image)resources.GetObject("BtnAbrirRelatorio.Image");
            BtnAbrirRelatorio.Location = new Point(12, 12);
            BtnAbrirRelatorio.Name = "BtnAbrirRelatorio";
            BtnAbrirRelatorio.Size = new Size(43, 43);
            BtnAbrirRelatorio.TabIndex = 22;
            BtnAbrirRelatorio.UseVisualStyleBackColor = true;
            BtnAbrirRelatorio.Click += BtnAbrirRelatorio_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnFechar.FlatStyle = FlatStyle.Flat;
            BtnFechar.Image = (Image)resources.GetObject("BtnFechar.Image");
            BtnFechar.Location = new Point(12, 394);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(43, 43);
            BtnFechar.TabIndex = 21;
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // PnlFiltros
            // 
            PnlFiltros.Controls.Add(panel1);
            PnlFiltros.Dock = DockStyle.Top;
            PnlFiltros.Location = new Point(67, 0);
            PnlFiltros.MinimumSize = new Size(0, 56);
            PnlFiltros.Name = "PnlFiltros";
            PnlFiltros.Size = new Size(733, 133);
            PnlFiltros.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnFiltrar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(632, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(101, 133);
            panel1.TabIndex = 0;
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnFiltrar.FlatStyle = FlatStyle.Flat;
            BtnFiltrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFiltrar.Image = (Image)resources.GetObject("BtnFiltrar.Image");
            BtnFiltrar.Location = new Point(3, 82);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(93, 46);
            BtnFiltrar.TabIndex = 40;
            BtnFiltrar.Text = "Filtrar";
            BtnFiltrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFiltrar.UseVisualStyleBackColor = true;
            BtnFiltrar.Click += BtnFiltrar_Click;
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
            DgvDados.Location = new Point(67, 133);
            DgvDados.MultiSelect = false;
            DgvDados.Name = "DgvDados";
            DgvDados.ReadOnly = true;
            DgvDados.RowHeadersVisible = false;
            DgvDados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvDados.RowTemplate.Height = 25;
            DgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDados.ShowCellErrors = false;
            DgvDados.Size = new Size(733, 317);
            DgvDados.TabIndex = 4;
            // 
            // BtnExportarPlanilha
            // 
            BtnExportarPlanilha.FlatStyle = FlatStyle.Flat;
            BtnExportarPlanilha.Image = (Image)resources.GetObject("BtnExportarPlanilha.Image");
            BtnExportarPlanilha.Location = new Point(12, 61);
            BtnExportarPlanilha.Name = "BtnExportarPlanilha";
            BtnExportarPlanilha.Size = new Size(43, 43);
            BtnExportarPlanilha.TabIndex = 23;
            BtnExportarPlanilha.UseVisualStyleBackColor = true;
            BtnExportarPlanilha.Click += BtnExportarPlanilha_Click;
            // 
            // FrmRelatorioBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvDados);
            Controls.Add(PnlFiltros);
            Controls.Add(PnlLateral);
            Name = "FrmRelatorioBase";
            Text = "FrmRelatorioBase";
            PnlLateral.ResumeLayout(false);
            PnlFiltros.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel PnlLateral;
        private Button BtnAbrirRelatorio;
        private Button BtnFechar;
        public Panel PnlFiltros;
        private Button BtnFiltrar;
        private Panel panel1;
        public DataGridView DgvDados;
        private Button BtnExportarPlanilha;
    }
}