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

namespace SisCaixaEstoque.Formularios.Consultas
{
    public partial class FrmConsultarProdutoVenda : FrmConsultarBase
    {
        public decimal VLVALORVENDA { get; set; }
        public int VLQUANTIDADE { get; set; }


        public FrmConsultarProdutoVenda()
        {
            InitializeComponent();
        }

        public override void Consultar()
        {
            try
            {
                DataGridViewComum objGridView = new(ref DgvDados);
                objGridView.AdicionaColuna(new GridViewColunas("Nome", "DSNOMEPRODUTO", DataGridViewAutoSizeColumnMode.Fill, 100, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("Valor", "VLVALORVENDA", DataGridViewAutoSizeColumnMode.NotSet, 50, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("Quanti.", "VLQUANTIDADE", DataGridViewAutoSizeColumnMode.NotSet, 50, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("IDPRODUTO", "IDPRODUTO", 0, false));

                DataGridViewButtonColumn colunaRemover = new()
                {
                    HeaderText = "Sel.",
                    Text = "✔",
                    UseColumnTextForButtonValue = true,
                    Width = 70
                };
                objGridView.Finalizar(BncSelects.BuscarProdutoVenda("WHERE PRO.DSNOMEPRODUTO LIKE '%" + TxbNome.Text + "%'"), true);

                DgvDados.Columns.Add(colunaRemover);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void Adicionar()
        {
            try
            {
                new FrmCadastroProduto().ShowDialog();
                Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void Selecionar(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == DgvDados.Columns["IDPRODUTO"].Index + 1)
                {
                    ID = Convert.ToInt32(DgvDados.Rows[e.RowIndex].Cells["IDPRODUTO"].Value);
#pragma warning disable CS8601 // Possível atribuição de referência nula.
                    DESCRICAO = Convert.ToString(DgvDados.Rows[e.RowIndex].Cells["DSNOMEPRODUTO"].Value);
#pragma warning restore CS8601 // Possível atribuição de referência nula.
                    VLVALORVENDA = Convert.ToDecimal(DgvDados.Rows[e.RowIndex].Cells["VLVALORVENDA"].Value);
                    VLQUANTIDADE = Convert.ToInt32(DgvDados.Rows[e.RowIndex].Cells["VLQUANTIDADE"].Value);
                    Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
