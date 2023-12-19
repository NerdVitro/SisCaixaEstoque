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
