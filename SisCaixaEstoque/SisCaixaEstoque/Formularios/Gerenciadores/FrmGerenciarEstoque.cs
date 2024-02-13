using SisCaixaEstoque.Banco.Consultas;
using SisCaixaEstoque.Classes;
using SisCaixaEstoque.Formularios.Base;
using SisCaixaEstoque.Formularios.Cadastros;
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

namespace SisCaixaEstoque.Formularios.Gerenciadores
{
    public partial class FrmGerenciarEstoque : FrmGerenciarCadastroBase
    {
        public FrmGerenciarEstoque()
        {
            InitializeComponent();
        }


        private int IDPRODUTO;
        private int IDFORNECEDOR;

        public override void Adicionar()
        {
            try
            {
                new FrmCadastroEstoque().ShowDialog();
                Filtrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void Editar()
        {
            try
            {
                new FrmCadastroEstoque().ShowDialog();
                Filtrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void Filtrar()
        {
            try
            {
                DataGridViewComum objGridView = new(ref DgvDados);
                objGridView.AdicionaColuna(new GridViewColunas("Produto", "DSNOMEPRODUTO", DataGridViewAutoSizeColumnMode.Fill, 100, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("Fornecedor", "DSNOMECOMPLETO", DataGridViewAutoSizeColumnMode.Fill, 300, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("Cód. Produto", "CDCODPRODUTO", DataGridViewAutoSizeColumnMode.None, 200, true, DataGridViewContentAlignment.MiddleLeft, false));
                objGridView.AdicionaColuna(new GridViewColunas("Lote", "DSLOTE", DataGridViewAutoSizeColumnMode.None, 110, true, DataGridViewContentAlignment.MiddleLeft, false));
                objGridView.AdicionaColuna(new GridViewColunas("Valor Venda", "VLVALORVENDA", DataGridViewAutoSizeColumnMode.None, 110, true, DataGridViewContentAlignment.MiddleLeft, false));
                objGridView.AdicionaColuna(new GridViewColunas("IDESTOQUE", "IDESTOQUE", 0, false));

                string WHERE =  "WHERE 1 = 1 ";
                if (IDPRODUTO != 0)
                {
                    WHERE += " AND EST.IDPRODUTO = " + IDFORNECEDOR;
                }
                if (IDFORNECEDOR != 0)
                {
                    WHERE += " AND EST.IDFORNECEDOR = " + IDFORNECEDOR;
                }

                objGridView.Finalizar(BncSelects.BuscarEstoque(WHERE), true);
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
