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

namespace SisCaixaEstoque.Formularios.Gerenciadores
{
    public partial class FrmGerenciarFormaPagamento : FrmGerenciarCadastroBase
    {
        public FrmGerenciarFormaPagamento()
        {
            InitializeComponent();
        }

        public override void Adicionar()
        {
            try
            {
                new FrmCadastroFormaPagamento().ShowDialog();
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
                new FrmCadastroFormaPagamento().ShowDialog();
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
                objGridView.AdicionaColuna(new GridViewColunas("Descrição", "DSTIPOPAGAMENTO", DataGridViewAutoSizeColumnMode.Fill, 100, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("Taxa", "VLTAXA", DataGridViewAutoSizeColumnMode.Fill, 300, true, DataGridViewContentAlignment.MiddleLeft, false, "P2"));
                objGridView.AdicionaColuna(new GridViewColunas("IDTIPOPAGAMENTO", "IDTIPOPAGAMENTO", 0, false));
                objGridView.Finalizar(BncSelects.BuscarTipoPagamento("WHERE FOR.DSTIPOPAGAMENTO LIKE '%" + TxbDescricao.Text + "%'"), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
