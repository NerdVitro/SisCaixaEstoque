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
        public DialogResult Result = DialogResult.Cancel;
        private int IDFormaPgamento;

        public FrmPagamento()
        {
            InitializeComponent();
            ConfigurarDgvPagamento();
            SetTelaInicial();
        }

        private void SetTelaInicial()
        {

            // Adiciona uma linha com valores à DataGridView
            DgvPagamento.Rows.Add(1, "Cartão de Crédito", 50.00);
            DgvPagamento.Rows.Add(2, "Cartão de Débito", 30.00);
            DgvPagamento.Rows.Add(3, "Dinheiro", 25.50);
        }
        private void ConfigurarDgvPagamento()
        {
            DataGridViewTextBoxColumn IdFormaPagamento = new()
            {
                HeaderText = "ID",
                Name = "ID",
                Visible = false
            };


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
            DgvPagamento.Columns.Add(IdFormaPagamento);
            DgvPagamento.Columns.Add(colunaNome);
            DgvPagamento.Columns.Add(colunaPreco);
            DgvPagamento.Columns.Add(colunaRemover);

            // Definir os tamanhos das colunas
            DgvPagamento.Columns["PrecoProduto"].Width = 100;
        }

        private void BtnConsultaFormaPagamento_Click(object sender, EventArgs e)
        {
            try
            {

                //FrmConsultaFormaPagemento consulta = new FrmConsultaFormaPagemento(TxbFormaPagamento.Text);
                //consulta.ShowDialog();

                //TxbFormaPagamento.Text = consulta.NomeFormaPagamento;
                //IDFormaPgamento = consulta.IDFormaPgamento;
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
                    DgvPagamento.Rows.Add(IDFormaPgamento, TxbFormaPagamento.Text, Convert.ToDecimal(TxbValorPago.Text));
                    TxbFormaPagamento.Text = "";
                    IDFormaPgamento = 0;
                    TxbValorPago.Text = "";
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
                if (e.RowIndex >= 0 && e.ColumnIndex == 3)
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DgvPagamento.Rows.RemoveAt(e.RowIndex);
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
