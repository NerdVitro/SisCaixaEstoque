using SisCaixaEstoque.Banco.Cadastros;
using SisCaixaEstoque.Banco.Validacoes;
using SisCaixaEstoque.Formularios.Base;
using SisCaixaEstoque.Formularios.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCaixaEstoque.Formularios
{
    public partial class FrmCadastroEstoque : FrmCadastroBase
    {
        public FrmCadastroEstoque()
        {
            InitializeComponent();
        }

        private int IDPRODUTO;
        private int IDFORNECEDOR;

        public override void Salvar()
        {
            try
            {
                string ssxRetorno = /*BncValidacoesCadastros.ValidarFornecedor(TxbNomeCompleto.Text, TxbNomeFantasia.Text, TxbCPFCNPJ.Text)*/ "";
                if (ssxRetorno == string.Empty)
                {
                    BncInserts.SalvarEstoque(
                        IDPRODUTO,
                        IDFORNECEDOR,
                        Convert.ToInt32(TxbCodigo.Text),
                        Convert.ToInt32(TxbLote.Text),
                        Convert.ToDecimal(TxbValorCompra.Text),
                        Convert.ToDecimal(TxbValorVenda.Text),
                        Convert.ToDecimal(TxbQuantidade.Text)
                        );

                    IDPRODUTO = 0;
                    TxbProduto.Text = "";
                    IDFORNECEDOR = 0;
                    TxbFornecedor.Text = "";
                    TxbCodigo.Text = "";
                    TxbLote.Text = "";
                    TxbValorCompra.Text = "";
                    TxbValorVenda.Text = "";
                    TxbQuantidade.Text = "";
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

        private void BtnPesquisarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultarProduto consulta = new();

                consulta.ShowDialog();
                IDPRODUTO = consulta.ID;
                TxbProduto.Text = consulta.DESCRICAO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnPesquisarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultarFornecedor consulta = new();

                consulta.ShowDialog();
                IDFORNECEDOR = consulta.ID;
                TxbFornecedor.Text = consulta.DESCRICAO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
