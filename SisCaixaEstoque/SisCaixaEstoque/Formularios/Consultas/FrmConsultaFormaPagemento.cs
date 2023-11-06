using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCaixaEstoque.Formularios.Consultas
{
    public partial class FrmConsultaFormaPagemento : Form
    {
        public int IDFormaPgamento;
        public string NomeFormaPagamento;


        public FrmConsultaFormaPagemento(string parNome)
        {
            InitializeComponent();

            TxbFormaPagamento.Text = parNome;

            ConfigurarDgvPagamento();
            SetTelaInicial();
        }

        private void SetTelaInicial()
        {

            // Adiciona uma linha com valores à DataGridView
            DgvPagamento.Rows.Add(1, "Cartão de Crédito");
            DgvPagamento.Rows.Add(2, "Cartão de Débito");
            DgvPagamento.Rows.Add(3, "Dinheiro");
        }
        private void ConfigurarDgvPagamento()
        {
            DataGridViewTextBoxColumn IdFormaPagamento = new()
            {
                HeaderText = "Id",
                Name = "Id",
                Visible = false
            };

            DataGridViewTextBoxColumn colunaNome = new()
            {
                HeaderText = "Forma Pagamento",
                Name = "FormaPagamento",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            DataGridViewButtonColumn colunaRemover = new()
            {
                HeaderText = "Selecionar",
                Text = "x",
                UseColumnTextForButtonValue = true,
                Width = 70
            };

            // Adicionar as colunas à DataGridView
            DgvPagamento.Columns.Add(IdFormaPagamento);
            DgvPagamento.Columns.Add(colunaNome);
            DgvPagamento.Columns.Add(colunaRemover);

        }

        private void DgvPagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 2)
                {
                    NomeFormaPagamento = (string)DgvPagamento.Rows[e.RowIndex].Cells["FormaPagamento"].Value ?? "";
                    IDFormaPgamento = (int)(DgvPagamento.Rows[e.RowIndex].Cells["Id"].Value ?? 0);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
