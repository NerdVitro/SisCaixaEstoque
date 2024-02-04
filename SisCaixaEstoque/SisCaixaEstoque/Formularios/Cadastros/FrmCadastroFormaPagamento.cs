using SisCaixaEstoque.Banco.Cadastros;
using SisCaixaEstoque.Banco.Validacoes;
using SisCaixaEstoque.Formularios.Base;
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
    public partial class FrmCadastroFormaPagamento : FrmCadastroBase
    {
        public FrmCadastroFormaPagamento()
        {
            InitializeComponent();
            TxbValorTaxa.MaxLength = 5;

            CbbTipoPagamento.Items.Add("Dinheiro");
            CbbTipoPagamento.Items.Add("Cartão Crédito");
            CbbTipoPagamento.Items.Add("Cartão Débito");
            CbbTipoPagamento.Items.Add("Crediário");

            CbbTipoPagamento.SelectedIndex = 0;
        }

        public override void Salvar()
        {
            try
            {
                string ssxRetorno = BncValidacoesCadastros.ValidarTipoPagamento(CbbTipoPagamento.SelectedText);
                if (ssxRetorno == string.Empty)
                {
                    BncInserts.SalvarTipoPagamento(CbbTipoPagamento.SelectedText, Convert.ToDecimal(TxbValorTaxa.Text));
                    CbbTipoPagamento.SelectedIndex = 0;
                    TxbValorTaxa.Text = "";
                }
                else
                {
                    MessageBox.Show(ssxRetorno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxbValorTaxa_KeyPress(object sender, KeyPressEventArgs e)
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
                            else if (((TextBox)sender).TextLength >= 2)
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
            catch (Exception)
            {
                //throw;
            }
        }
    }
}
