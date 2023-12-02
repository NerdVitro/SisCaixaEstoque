using SisCaixaEstoque.Classes;
using SisCaixaEstoque.Formularios.Consultas;
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

        public ValidacaoLogin.NivelAcesso NivelUsuario;
        public FrmPrincipal(ValidacaoLogin.NivelAcesso parNivelUsuario)
        {
            NivelUsuario = parNivelUsuario;
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
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 2)
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DgvProdutosVenda.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmConsultarCliente().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnPesquisarProduto_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnAdicinarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                // Adiciona uma linha com valores à DataGridView
                DgvProdutosVenda.Rows.Add("Produto 1", 50.00);
                DgvProdutosVenda.Rows.Add("Produto 2", 30.00);
                DgvProdutosVenda.Rows.Add("Produto 3", 25.50);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Botões laterais
        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCaixa Caixa = new();
                Caixa.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroCliente Cliente = new();
                Cliente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnProduto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroProduto Produto = new();
                Produto.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroEstoque Estoque = new();
                Estoque.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnConfiguracao_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConfiguracao Configuracao = new();
                Configuracao.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
