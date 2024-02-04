using SisCaixaEstoque.Classes;
using SisCaixaEstoque.Formularios.Consultas;
using SisCaixaEstoque.Formularios.Gerenciadores;
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

        public int IDCliente = 0;

        private void SetTelaInicial()
        {
            try
            {
                ToolTipMensagens.SetToolTip(BtnCaixa, ConstantesNomeAjudaBotao.TelaInicial.BotaoCaixa);
                ToolTipMensagens.SetToolTip(BtnCliente, ConstantesNomeAjudaBotao.TelaInicial.BotaoCliente);
                ToolTipMensagens.SetToolTip(BtnProduto, ConstantesNomeAjudaBotao.TelaInicial.BotaoProduto);
                ToolTipMensagens.SetToolTip(BtnEstoque, ConstantesNomeAjudaBotao.TelaInicial.BotaoEstoque);
                ToolTipMensagens.SetToolTip(BtnConfiguracao, ConstantesNomeAjudaBotao.TelaInicial.BotaoConfiguracao);
                ToolTipMensagens.SetToolTip(BtnSair, ConstantesNomeAjudaBotao.TelaInicial.BotaoSair);

                ToolTipMensagens.SetToolTip(BtnFinalizar, ConstantesNomeAjudaBotao.TelaInicial.BotaoFinalizar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ConfigurarDgvProdutosVenda()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                        decimal total = 0;
                        foreach (DataGridViewRow linha in DgvProdutosVenda.Rows)
                        {
                            if (linha.Cells[1].Value != null && decimal.TryParse(linha.Cells[1].Value.ToString(), out decimal valor))
                            {
                                total += valor;
                                LblTotalVenda.Text = $"R$ {total:N2}";
                            }
                        }
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
                FrmConsultarCliente consulta = new();

                consulta.ShowDialog();
                IDCliente = consulta.ID;
                TxbCliente.Text = consulta.DESCRICAO;
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


                decimal total = 0;
                foreach (DataGridViewRow linha in DgvProdutosVenda.Rows)
                {
                    if (linha.Cells[1].Value != null && decimal.TryParse(linha.Cells[1].Value.ToString(), out decimal valor))
                    {
                        total += valor;
                        LblTotalVenda.Text = $"R$ {total:N2}";
                    }
                }
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
                new FrmGerenciarCliente().ShowDialog();
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
                FrmGerenciarProduto Produto = new();
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
        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            try
            {
                //FrmConfiguracao Configuracao = new();
                //Configuracao.ShowDialog();
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
