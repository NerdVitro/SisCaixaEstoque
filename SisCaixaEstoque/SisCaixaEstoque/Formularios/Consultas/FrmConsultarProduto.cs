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
    public partial class FrmConsultarProduto : FrmConsultarBase
    {
        public FrmConsultarProduto()
        {
            InitializeComponent();
        }

        public override void Consultar()
        {
            try
            {
                DataGridViewComum objGridView = new(ref DgvDados);
                objGridView.AdicionaColuna(new GridViewColunas("Nome", "DSNOMEPRODUTO", DataGridViewAutoSizeColumnMode.Fill, 100, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("IDPRODUTO", "IDPRODUTO", 0, false));

                DataGridViewButtonColumn colunaRemover = new()
                {
                    HeaderText = "Sel.",
                    Text = "✔",
                    UseColumnTextForButtonValue = true,
                    Width = 70
                };
                objGridView.Finalizar(BncSelects.BuscarProduto("WHERE PRO.DSNOMEPRODUTO LIKE '%" + TxbNome.Text + "%'"), true);

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
                SelecionarItemByID(e, "IDPRODUTO", "DSNOMECOMPLETO");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
