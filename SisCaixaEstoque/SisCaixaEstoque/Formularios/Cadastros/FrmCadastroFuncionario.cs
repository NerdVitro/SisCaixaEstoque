using SisCaixaEstoque.Banco.Cadastros;
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
        public bool Validar()
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void Salvar()
        {
            try
            {
                if (Validar())
                {
                    BncInserts.SalvarFuncionario(
                        TxbNomeCompleto.Text,
                        TxbCPFCNPJ.Text,
                        TxbEndereco.Text,
                        TxbEndereco.Text,
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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
