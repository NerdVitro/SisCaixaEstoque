using SisCaixaEstoque.Classes;
using SisCaixaEstoque.Formularios.Base;
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
    public partial class FrmConfiguracao : FrmBaseVazio
    {
        public FrmConfiguracao()
        {
            InitializeComponent();

            ToolTipMensagens.SetToolTip(BtnFuncionario, ConstantesNomeAjudaBotao.TelaConfiguracao.BotaoFuncionario);
            ToolTipMensagens.SetToolTip(BtnFormaPagamento, ConstantesNomeAjudaBotao.TelaConfiguracao.BtnFormaPagamento);
            ToolTipMensagens.SetToolTip(BtnFormaPagamento, ConstantesNomeAjudaBotao.TelaConfiguracao.BtnFornecedor);
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmGerenciarFuncionario().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnFormaPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmGerenciarFormaPagamento().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmGerenciarFornecedor().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
