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

namespace SisCaixaEstoque.Formularios.Cadastros
{
    public partial class FrmCadastroFornecedor : FrmCadastroBase
    {
        public FrmCadastroFornecedor()
        {
            InitializeComponent();
        }
        public override void Salvar()
        {
            try
            {
                string ssxRetorno = BncValidacoesCadastros.ValidarFornecedor(TxbNomeCompleto.Text, TxbNomeFantasia.Text, TxbCPFCNPJ.Text);
                if (ssxRetorno == string.Empty)
                {
                    BncInserts.SalvarFornecedor(
                        TxbNomeCompleto.Text,
                        TxbNomeFantasia.Text,
                        TxbCPFCNPJ.Text,
                        TxbCidade.Text,
                        TxbEndereco.Text,
                        TxbEstado.Text,
                        TxbEmail.Text,
                        TxbTelefone.Text,
                        TxbCelular.Text
                        );
                    TxbNomeCompleto.Text = "";
                    TxbNomeFantasia.Text = "";
                    TxbCPFCNPJ.Text = "";
                    TxbCidade.Text = "";
                    TxbEndereco.Text = "";
                    TxbEstado.Text = "";
                    TxbEmail.Text = "";
                    TxbTelefone.Text = "";
                    TxbCelular.Text = "";
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
