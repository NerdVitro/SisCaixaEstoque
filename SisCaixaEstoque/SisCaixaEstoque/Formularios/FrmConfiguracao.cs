using SisCaixaEstoque.Classes;
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
    public partial class FrmConfiguracao : Form
    {
        public FrmConfiguracao()
        {
            InitializeComponent();

            ToolTipMensagens.SetToolTip(BtnFuncionario, ConstantesNomeAjudaBotao.TelaConfiguracao.BotaoFuncionario);
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
    }
}
