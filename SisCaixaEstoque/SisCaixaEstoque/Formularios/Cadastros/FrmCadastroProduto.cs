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
    public partial class FrmCadastroProduto : FrmCadastroBase
    {
        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                string ssxRetorno = BncValidacoesCadastros.ValidarProduto(TxbNome.Text);
                if (ssxRetorno == string.Empty)
                {
                    BncInserts.SalvarProduto(TxbNome.Text);
                    TxbNome.Text = "";
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
    }
}
