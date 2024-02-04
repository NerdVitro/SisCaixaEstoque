using SisCaixaEstoque.Banco.Cadastros;
using SisCaixaEstoque.Banco.Consultas;
using SisCaixaEstoque.Banco.Validacoes;
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
    public partial class FrmConsultarCliente : FrmConsultarBase
    {
        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        public override void Consultar()
        {
            try
            {
                DataGridViewComum objGridView = new(ref DgvDados);
                objGridView.AdicionaColuna(new GridViewColunas("Nome", "DSNOMECOMPLETO", DataGridViewAutoSizeColumnMode.Fill, 100, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("Endereço", "DSENDERECO", DataGridViewAutoSizeColumnMode.Fill, 300, true, DataGridViewContentAlignment.MiddleLeft, false, ""));
                objGridView.AdicionaColuna(new GridViewColunas("WhatsApp", "VLWHATS", DataGridViewAutoSizeColumnMode.None, 110, true, DataGridViewContentAlignment.MiddleLeft, false));
                objGridView.AdicionaColuna(new GridViewColunas("IDCLIENTE", "IDCLIENTE", 0, false));

                DataGridViewButtonColumn colunaRemover = new()
                {
                    HeaderText = "Sel.",
                    Text = "✔",
                    UseColumnTextForButtonValue = true,
                    Width = 70
                };
                objGridView.Finalizar(BncSelects.BuscarCliente("WHERE CLI.DSNOMECOMPLETO LIKE '%" + TxbNome.Text + "%'"), true);

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
                new FrmCadastroCliente().ShowDialog();
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
                SelecionarItemByID(e, "IDCLIENTE", "DSNOMECOMPLETO");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
