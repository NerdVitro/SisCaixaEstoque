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
    public partial class FrmCadastroFuncionario : FrmCadastroBase
    {
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            try
            {
                string ssxRetorno = BncValidacoesCadastros.ValidarFuncionario(TxbNomeCompleto.Text, TxbCPFCNPJ.Text);
                if (ssxRetorno == string.Empty)
                {
                    BncInserts.SalvarFuncionario(
                        TxbNomeCompleto.Text,
                        TxbCPFCNPJ.Text,
                        TxbEndereco.Text,
                        TxbCidade.Text,
                        TxbEstado.Text,
                        TxbEmail.Text,
                        TxbTelefone.Text,
                        TxbCelular.Text,
                        TxbWhatsapp.Text
                        );
                    if (CkbCriarUsuario.Checked)
                    {
                        BncInserts.SalvarUsuario(TxbNomeCompleto.Text.Split(" ")[0]);
                    }

                    TxbNomeCompleto.Text = "";
                    TxbCPFCNPJ.Text = "";
                    TxbEndereco.Text = "";
                    TxbCidade.Text = "";
                    TxbEstado.Text = "";
                    TxbEmail.Text = "";
                    TxbTelefone.Text = "";
                    TxbCelular.Text = "";
                    TxbWhatsapp.Text = "";
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
