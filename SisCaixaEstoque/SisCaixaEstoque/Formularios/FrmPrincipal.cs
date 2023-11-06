using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCaixaEstoque.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            ConfigurarDgvProdutosVenda();
            SetTelaInicial();
        }

        private void SetTelaInicial()
        {

            // Adiciona uma linha com valores à DataGridView
            DgvProdutosVenda.Rows.Add("Produto 1", 50.00);
            DgvProdutosVenda.Rows.Add("Produto 2", 30.00);
            DgvProdutosVenda.Rows.Add("Produto 3", 25.50);
        }
        private void ConfigurarDgvProdutosVenda()
        {
            // Criar e configurar as colunas
            DataGridViewTextBoxColumn colunaNome = new()
            {
                HeaderText = "Nome do Produto",
                Name = "NomeProduto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            DataGridViewTextBoxColumn colunaPreco = new()
            {
                HeaderText = "Preço",
                Name = "PrecoProduto"
            };
            colunaPreco.DefaultCellStyle.Format = "C"; // Formato de moeda
            colunaPreco.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinhamento à direita

            DataGridViewButtonColumn colunaRemover = new()
            {
                HeaderText = "Remover",
                Text = "X",
                UseColumnTextForButtonValue = true,
                Width = 70
            };

            // Adicionar as colunas à DataGridView
            DgvProdutosVenda.Columns.Add(colunaNome);
            DgvProdutosVenda.Columns.Add(colunaPreco);
            DgvProdutosVenda.Columns.Add(colunaRemover);

            // Definir os tamanhos das colunas
            DgvProdutosVenda.Columns["PrecoProduto"].Width = 100;
        }
        
        private void DgvProdutosVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique ocorreu na coluna de botão e não no cabeçalho da coluna
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                // Pede uma confirmação antes de excluir a linha
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Se o usuário clicar em "Sim", remove a linha
                if (resultado == DialogResult.Yes)
                {
                    DgvProdutosVenda.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void BtnPesquisarCliente_Click(object sender, EventArgs e)
        {

        }
        private void BtnPesquisarProduto_Click(object sender, EventArgs e)
        {
            // Adiciona uma linha com valores à DataGridView
            DgvProdutosVenda.Rows.Add("Produto 1", 50.00);
            DgvProdutosVenda.Rows.Add("Produto 2", 30.00);
            DgvProdutosVenda.Rows.Add("Produto 3", 25.50);
        }
        private void BtnAdicinarProduto_Click(object sender, EventArgs e)
        {

        }
        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            FrmPagamento pagaemtno = new();
            pagaemtno.ShowDialog();
            if (pagaemtno.Result == DialogResult.OK)
            {
                //SetTelaInicial();
                if (DgvProdutosVenda.Rows.Count > 0)
                {
                    DgvProdutosVenda.Rows.Clear();
                }
            }
            else
            {
                // Não fazer nada
            }
        }
    }
}
