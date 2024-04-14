using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCaixaEstoque.Formularios.Base
{
    public partial class FrmRelatorioBase : FrmBaseVazio
    {
        public FrmRelatorioBase()
        {
            InitializeComponent();
        }

        private void BtnAbrirRelatorio_Click(object sender, EventArgs e)
        {
            AbrirRelatorio();
        }
        private void BtnExportarPlanilha_Click(object sender, EventArgs e)
        {
            ExportarPlanilha();
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public virtual void AbrirRelatorio()
        {

        }
        public virtual void ExportarPlanilha()
        {

        }
        public virtual void Filtrar()
        {

        }


        public static void ExportarDataGridViewToExcel(DataGridView dataGridView, string parNomeArquivo)
        {
            try
            {
                // Cria um novo workbook do Excel
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("DataGridView");

                // Popula o Excel com os dados da DataGridView
                DataTable dt = new ();

                // Adiciona as colunas
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    dt.Columns.Add(column.HeaderText, column.ValueType);
                }

                // Adiciona as linhas
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    dt.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                }

                // Insere os dados no Excel
                worksheet.Cell(1, 1).InsertTable(dt.AsEnumerable());

                // Salva o arquivo Excel
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "Arquivo Excel|*.xlsx",
                    FileName = parNomeArquivo + ".xlsx"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Arquivo Excel exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
