using SisCaixaEstoque.Banco.Consultas;
using SisCaixaEstoque.Classes;
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

namespace SisCaixaEstoque.Formularios.Relatorios
{
    public partial class FrmRelatorioVendas : FrmRelatorioBase
    {
        public FrmRelatorioVendas()
        {
            InitializeComponent();
        }


        public override void AbrirRelatorio()
        {
            try
            {
                new FrmCadastroCliente().ShowDialog();
                Filtrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void ExportarPlanilha()
        {
            try
            {
                ExportarDataGridViewToExcel(DgvDados, "RelatorioVendas");
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
                objGridView.AdicionaColuna(new GridViewColunas("Num. Venda", "IDVENDA", DataGridViewAutoSizeColumnMode.None, 110, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("Data Venda", "DATAVENDA", DataGridViewAutoSizeColumnMode.None, 120, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("Cliente", "DSNOMECOMPLETO", DataGridViewAutoSizeColumnMode.Fill, 200, true, DataGridViewContentAlignment.MiddleLeft, false));
                objGridView.AdicionaColuna(new GridViewColunas("Produto", "DSNOMEPRODUTO", DataGridViewAutoSizeColumnMode.Fill, 200, true, DataGridViewContentAlignment.MiddleLeft, false));
                objGridView.AdicionaColuna(new GridViewColunas("Quant. Vendida", "VLQUANTIDADE", DataGridViewAutoSizeColumnMode.None, 130, true, DataGridViewContentAlignment.MiddleRight, false, "N0"));
                objGridView.AdicionaColuna(new GridViewColunas("Preço Unit.", "VLVALORUNIT", DataGridViewAutoSizeColumnMode.None, 100, true, DataGridViewContentAlignment.MiddleRight, false, "N2"));
                objGridView.AdicionaColuna(new GridViewColunas("Total Venda", "VLVALORVENDA", DataGridViewAutoSizeColumnMode.None, 110, true, DataGridViewContentAlignment.MiddleRight, false, "N2"));
                objGridView.AdicionaColuna(new GridViewColunas("1º Forma Pag.", "DSTIPOPAGAMENTO", DataGridViewAutoSizeColumnMode.None, 120, true, DataGridViewContentAlignment.MiddleLeft, false));
                //objGridView.AdicionaColuna(new GridViewColunas("Vendedor", "VLWHATS", DataGridViewAutoSizeColumnMode.None, 110, true, DataGridViewContentAlignment.MiddleLeft, false));
                string SqlWhere = " WHERE  1 = 1";
                if (!string.IsNullOrEmpty(TxbCliente.Text))
                {
                    SqlWhere += " AND CLI.DSNOMECOMPLETO LIKE '%" + TxbCliente.Text + "%' ";
                }
                if (!string.IsNullOrEmpty(TxbProduto.Text))
                {
                    SqlWhere += " AND PRO.DSNOMEPRODUTO LIKE '%" + TxbProduto.Text + "%' ";
                }
                objGridView.Finalizar(BncSelects.BuscarDadosRelatorioVendas(SqlWhere), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
