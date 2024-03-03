using SisCaixaEstoque.Banco.Cadastros;
using SisCaixaEstoque.Banco.Consultas;
using SisCaixaEstoque.Classes;
using SisCaixaEstoque.Classes.BusinessObjects;
using SisCaixaEstoque.Formularios.Consultas;
using SisCaixaEstoque.Formularios.Gerenciadores;
using System;
using System.CodeDom;
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
        public int IDCliente = 0;
        public int IDPRODUTO = 0;
        public decimal VLVALORVENDA = 0;
        public int VLQUANTIDADE = 0;

        public FrmPrincipal(ValidacaoLogin.NivelAcesso parNivelUsuario)
        {
            NivelUsuario = parNivelUsuario;
            InitializeComponent();





            ConfigurarDgvProdutosVenda();
            SetTelaInicial();
        }
        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (DgvProdutosVenda.Rows.Count > 0)
                {
                    foreach (DataGridViewRow linha in DgvProdutosVenda.Rows)
                    {
                        BncUpdate.UpdateAlterarEstoque(Convert.ToInt32(linha.Cells["IDPRODUTO"].Value), Convert.ToInt32(linha.Cells["VLQUANTIDADE"].Value), true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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

                TxbQuantidade.MaxLength = 3;
                TxbQuantidade.Enabled = false;
                LblTotalVenda.Text = $"R$ {0:N2}";
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
                    HeaderText = "Preço Unit.",
                    Name = "PrecoProduto",
                    Width = 100,
                };
                colunaPreco.DefaultCellStyle.Format = "C"; // Formato de moeda
                colunaPreco.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinhamento à direita

                DataGridViewTextBoxColumn colunaPrecoTotal = new()
                {
                    HeaderText = "Preço Total",
                    Name = "PrecoProdutoTotal",
                    Width = 100,
                };
                colunaPrecoTotal.DefaultCellStyle.Format = "C"; // Formato de moeda
                colunaPrecoTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinhamento à direita

                DataGridViewTextBoxColumn colunaIDPRODUTO = new()
                {
                    HeaderText = "IDPRODUTO",
                    Name = "IDPRODUTO",
                    Visible = false
                };

                DataGridViewTextBoxColumn colunaQuantidade = new()
                {
                    HeaderText = "Quant.",
                    Name = "VLQUANTIDADE",
                    Width = 50,
                };
                colunaQuantidade.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinhamento à direita

                DataGridViewButtonColumn colunaRemover = new()
                {
                    HeaderText = "Remover",
                    Text = "X",
                    UseColumnTextForButtonValue = true,
                    Width = 70
                };

                // Adicionar as colunas à DataGridView
                DgvProdutosVenda.Columns.Add(colunaNome);
                DgvProdutosVenda.Columns.Add(colunaQuantidade);
                DgvProdutosVenda.Columns.Add(colunaPreco);
                DgvProdutosVenda.Columns.Add(colunaPrecoTotal);
                DgvProdutosVenda.Columns.Add(colunaIDPRODUTO);
                DgvProdutosVenda.Columns.Add(colunaRemover);
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
                FrmConsultarProdutoVenda consulta = new();

                consulta.ShowDialog();
                IDPRODUTO = consulta.ID;
                VLVALORVENDA = consulta.VLVALORVENDA;
                VLQUANTIDADE = consulta.VLQUANTIDADE;
                TxbProduto.Text = consulta.DESCRICAO;
                TxbQuantidade.Enabled = true;
                TxbQuantidade.Focus();
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
                if (IDPRODUTO != 0 && TxbQuantidade.Text != "")
                {
                    if (Convert.ToInt32(TxbQuantidade.Text) > VLQUANTIDADE)
                    {
                        MessageBox.Show("Informe a quantidade menor que " + VLQUANTIDADE);
                        TxbQuantidade.Focus();
                        return;
                    }
                    BncUpdate.UpdateAlterarEstoque(IDPRODUTO, Convert.ToInt32(TxbQuantidade.Text), false);

                    // Adiciona uma linha com valores à DataGridView
                    DgvProdutosVenda.Rows.Add(TxbProduto.Text, Convert.ToInt32(TxbQuantidade.Text), VLVALORVENDA, VLVALORVENDA * Convert.ToInt32(TxbQuantidade.Text), IDPRODUTO);

                    decimal total = 0;
                    foreach (DataGridViewRow linha in DgvProdutosVenda.Rows)
                    {
                        if (linha.Cells["PrecoProdutoTotal"].Value != null && decimal.TryParse(linha.Cells["PrecoProdutoTotal"].Value.ToString(), out decimal valor))
                        {
                            total += valor;
                        }
                    }
                    LblTotalVenda.Text = $"R$ {total:N2}";

                    IDPRODUTO = 0;
                    VLVALORVENDA = 0;
                    TxbProduto.Text = "";
                    TxbQuantidade.Text = "";
                    DgvProdutosVenda.Refresh();
                    TxbQuantidade.Enabled = false;
                }
                else if (IDPRODUTO == 0)
                {
                    MessageBox.Show("Informe o Produto");
                    BtnPesquisarProduto.Focus();
                }
                else if (TxbQuantidade.Text == "")
                {
                    MessageBox.Show("Informe a Quantidade");
                    TxbQuantidade.Focus();
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
                if (DgvProdutosVenda.Rows.Count > 0)
                {
                    List<CarrinhoComprasBO> carrinhoComprasBO = new();


                    foreach (DataGridViewRow linha in DgvProdutosVenda.Rows)
                    {
                        carrinhoComprasBO.Add(
                                new CarrinhoComprasBO()
                                {
                                    NomeProduto = Convert.ToString(linha.Cells["NomeProduto"].Value),
                                    IDPRODUTO = Convert.ToInt32(linha.Cells["IDPRODUTO"].Value),
                                    VLQUANTIDADE = Convert.ToDecimal(linha.Cells["VLQUANTIDADE"].Value),
                                    PrecoProduto = Convert.ToDecimal(linha.Cells["PrecoProduto"].Value),
                                    PrecoProdutoTotal = Convert.ToDecimal(linha.Cells["PrecoProdutoTotal"].Value),
                                }
                            );
                    }

                    FrmPagamento pagaemtno = new FrmPagamento(Convert.ToDecimal(LblTotalVenda.Text.Replace("R$ ","")),0, carrinhoComprasBO);
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
                else
                {
                    MessageBox.Show("Nenhum item no carrinho prar finalizar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TxbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void RemoverRegistro(DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 5)
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BncUpdate.UpdateAlterarEstoque(Convert.ToInt32(DgvProdutosVenda.Rows[e.RowIndex].Cells["IDPRODUTO"].Value), Convert.ToInt32(DgvProdutosVenda.Rows[e.RowIndex].Cells["VLQUANTIDADE"].Value), true);
                        DgvProdutosVenda.Rows.RemoveAt(e.RowIndex);

                        decimal total = 0;
                        foreach (DataGridViewRow linha in DgvProdutosVenda.Rows)
                        {
                            if (linha.Cells["PrecoProdutoTotal"].Value != null && decimal.TryParse(linha.Cells["PrecoProdutoTotal"].Value.ToString(), out decimal valor))
                            {
                                total += valor;
                            }
                        }
                        LblTotalVenda.Text = $"R$ {total:N2}";
                    }
                }
            }
            catch (Exception)
            {

                throw;
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
                FrmGerenciarEstoque Estoque = new();
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

        private void DgvProdutosVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RemoverRegistro(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
