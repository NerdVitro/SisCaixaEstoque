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
    public partial class FrmGerenciarCliente : FrmGerenciarCadastroBase
    {
        public FrmGerenciarCliente()
        {
            InitializeComponent();
            Filtrar();
        }


        public override void Adicionar()
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
        public override void Editar()
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
        public override void Filtrar()
        {
            try
            {
                DataGridViewComum objGridView = new(ref DgvDados);
                objGridView.AdicionaColuna(new GridViewColunas("Nome", "DSNOMECOMPLETO", DataGridViewAutoSizeColumnMode.Fill, 100, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("Endereço", "DSENDERECO", DataGridViewAutoSizeColumnMode.Fill, 300, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("E-mail", "DSEMAIL", DataGridViewAutoSizeColumnMode.None, 200, true, DataGridViewContentAlignment.MiddleLeft, false));
                objGridView.AdicionaColuna(new GridViewColunas("Celular", "VLCELULAR", DataGridViewAutoSizeColumnMode.None, 110, true, DataGridViewContentAlignment.MiddleLeft, false));
                objGridView.AdicionaColuna(new GridViewColunas("WhatsApp", "VLWHATS", DataGridViewAutoSizeColumnMode.None, 110, true, DataGridViewContentAlignment.MiddleLeft, false));
                objGridView.AdicionaColuna(new GridViewColunas("IDCLIENTE", "IDCLIENTE", 0, false));
                objGridView.Finalizar(BncSelects.BuscarCliente("WHERE CLI.DSNOMECOMPLETO LIKE '%" + TxbCliente.Text + "%'"), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
