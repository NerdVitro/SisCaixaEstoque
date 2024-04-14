using SisCaixaEstoque.Banco.Cadastros;
using SisCaixaEstoque.Banco.Consultas;
using SisCaixaEstoque.Classes;
using SisCaixaEstoque.Classes.BusinessObjects;
using SisCaixaEstoque.Formularios.Base;
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
    public partial class FrmPagamento : FrmBaseVazio
    {
        public decimal ValorVenda { get; set; }
        public int IDCAIXA { get; set; }
        public int IDCliente { get; set; }



        public DialogResult Result = DialogResult.Cancel;
        private int IDFormaPgamento;

        public FrmPagamento(int parIDCliente, decimal valorVenda, int iDCAIXA, List<CarrinhoComprasBO> parCarrinho)
        {
            IDCliente = parIDCliente;
            ValorVenda = valorVenda;
            IDCAIXA = iDCAIXA;


            InitializeComponent();
            ConfigurarDgvPagamento(parCarrinho);
            SetTelaInicial();
        }

        private void SetTelaInicial()
        {
            try
            {
                LblValorCompra.Text = $"R$ {ValorVenda:N2}";
                TxbValorPago.Text = $"{ValorVenda:N2}";


                // Adiciona uma linha com valores à DataGridView
                DgvPagamento.Rows.Add(1, "Cartão de Crédito", 50.00);
                DgvPagamento.Rows.Add(2, "Cartão de Débito", 30.00);
                DgvPagamento.Rows.Add(3, "Dinheiro", 25.50);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void ConfigurarDgvPagamento(List<CarrinhoComprasBO> parCarrinho)
        {
            try
            {
                DataGridViewComum objGridView = new(ref DgvProdutosVenda);
                objGridView.AdicionaColuna(new GridViewColunas("Nome", "NomeProduto", DataGridViewAutoSizeColumnMode.Fill, 100, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("Quanti.", "VLQUANTIDADE", DataGridViewAutoSizeColumnMode.NotSet, 50, true, DataGridViewContentAlignment.MiddleRight, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("Preço Unit.", "PrecoProduto", DataGridViewAutoSizeColumnMode.NotSet, 100, true, DataGridViewContentAlignment.MiddleRight, false, "C"));
                objGridView.AdicionaColuna(new GridViewColunas("Preço Total", "PrecoProdutoTotal", DataGridViewAutoSizeColumnMode.NotSet, 100, true, DataGridViewContentAlignment.MiddleRight, false, "C"));
                objGridView.AdicionaColuna(new GridViewColunas("IDPRODUTO", "IDPRODUTO", 0, false));
                objGridView.Finalizar(parCarrinho, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            DataGridViewTextBoxColumn IdFormaPagamento = new()
            {
                HeaderText = "ID",
                Name = "ID",
                Visible = false
            };


            DataGridViewTextBoxColumn colunaNome = new()
            {
                HeaderText = "Forma Pagamento",
                Name = "FormaPagamento",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            DataGridViewTextBoxColumn colunaPreco = new()
            {
                HeaderText = "Valor",
                Name = "Valor"
            };
            colunaPreco.DefaultCellStyle.Format = "C"; // Formato de moeda
            colunaPreco.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinhamento à direita

            DataGridViewTextBoxColumn colunaTroco = new()
            {
                HeaderText = "Troco",
                Name = "Troco"
            };
            colunaTroco.DefaultCellStyle.Format = "C"; // Formato de moeda
            colunaTroco.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinhamento à direita

            DataGridViewButtonColumn colunaRemover = new()
            {
                HeaderText = "Remover",
                Text = "X",
                UseColumnTextForButtonValue = true,
                Width = 70
            };

            // Adicionar as colunas à DataGridView
            DgvPagamento.Columns.Add(IdFormaPagamento);
            DgvPagamento.Columns.Add(colunaNome);
            DgvPagamento.Columns.Add(colunaPreco);
            DgvPagamento.Columns.Add(colunaTroco);
            DgvPagamento.Columns.Add(colunaRemover);

            // Definir os tamanhos das colunas
            DgvPagamento.Columns["Valor"].Width = 100;
            DgvPagamento.Columns["Troco"].Width = 100;
        }

        private void BtnConsultaFormaPagamento_Click(object sender, EventArgs e)
        {
            try
            {

                FrmConsultaFormaPagemento consulta = new();
                consulta.ShowDialog();

                TxbFormaPagamento.Text = consulta.DESCRICAO;
                IDFormaPgamento = consulta.ID;
                TxbValorPago.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnAdicionarFormaPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxbFormaPagamento.Text) && !string.IsNullOrEmpty(TxbValorPago.Text))
                {
                    decimal dcxTroco = string.IsNullOrEmpty(TxbValorTroco.Text) ? 0 : Convert.ToDecimal(TxbValorTroco.Text);

                    DgvPagamento.Rows.Add(IDFormaPgamento, TxbFormaPagamento.Text, Convert.ToDecimal(TxbValorPago.Text), dcxTroco);
                    TxbFormaPagamento.Text = "";
                    IDFormaPgamento = 0;
                    TxbValorPago.Text = "";
                    TxbValorTroco.Text = "";

                    decimal total = 0;
                    foreach (DataGridViewRow linha in DgvPagamento.Rows)
                    {
                        if (linha.Cells[2].Value != null && decimal.TryParse(linha.Cells[2].Value.ToString(), out decimal valor))
                        {
                            decimal.TryParse(linha.Cells[3].Value.ToString(), out decimal troco);
                            total += (valor - troco);
                            LblTotalPago.Text = $"R$ {total:N2}";
                        }
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
                DataTable dadosCarrinho = new();
                dadosCarrinho.Columns.Add("NomeProduto", typeof(string));
                dadosCarrinho.Columns.Add("VLQUANTIDADE", typeof(decimal));
                dadosCarrinho.Columns.Add("PrecoProduto", typeof(string));
                dadosCarrinho.Columns.Add("PrecoProdutoTotal", typeof(string));
                dadosCarrinho.Columns.Add("IDPRODUTO", typeof(int));
                foreach (DataGridViewRow linha in DgvProdutosVenda.Rows)
                {
                    dadosCarrinho.Rows.Add(
                            Convert.ToString(linha.Cells["NomeProduto"].Value),
                            Convert.ToDecimal(linha.Cells["VLQUANTIDADE"].Value),
                            Convert.ToDecimal(linha.Cells["PrecoProduto"].Value),
                            Convert.ToDecimal(linha.Cells["PrecoProdutoTotal"].Value),
                            Convert.ToInt32(linha.Cells["IDPRODUTO"].Value)
                        );
                }

                DataTable dadosFormasPagamento = new();
                dadosFormasPagamento.Columns.Add("ID", typeof(int));
                dadosFormasPagamento.Columns.Add("FormaPagamento", typeof(string));
                dadosFormasPagamento.Columns.Add("Valor", typeof(string));
                dadosFormasPagamento.Columns.Add("Troco", typeof(string));
                foreach (DataGridViewRow linha in DgvPagamento.Rows)
                {
                    dadosFormasPagamento.Rows.Add(
                            Convert.ToInt32(linha.Cells["ID"].Value),
                            Convert.ToString(linha.Cells["FormaPagamento"].Value),
                            Convert.ToDecimal(linha.Cells["Valor"].Value),
                            Convert.ToDecimal(linha.Cells["Troco"].Value)
                        );
                }

                BncInserts.SalvarVenda(IDCliente, ValorVenda, dadosCarrinho, dadosFormasPagamento);

                Result = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TxbValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\b')
                {
                    return;
                }
                else
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(','))
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            if (((TextBox)sender).Text.Contains(','))
                            {
                                if (((TextBox)sender).Text.Split(',')[1].Length >= 2 && !char.IsControl(e.KeyChar))
                                {
                                    e.Handled = true;
                                }
                            }
                            else if (((TextBox)sender).TextLength == 0 && e.KeyChar == ',')
                            {
                                e.Handled = true;
                            }
                            else if (((TextBox)sender).TextLength >= 9)
                            {
                                if (e.KeyChar != ',' && ((TextBox)sender).Text.Contains(','))
                                {
                                    e.Handled = true;
                                }
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

        private void DgvPagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 4)
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DgvPagamento.Rows.RemoveAt(e.RowIndex);
                        decimal total = 0;
                        foreach (DataGridViewRow linha in DgvPagamento.Rows)
                        {
                            if (linha.Cells[2].Value != null && decimal.TryParse(linha.Cells[2].Value.ToString(), out decimal valor))
                            {
                                total += valor;
                                LblTotalPago.Text = $"R$ {total:N2}";
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
    }
}
