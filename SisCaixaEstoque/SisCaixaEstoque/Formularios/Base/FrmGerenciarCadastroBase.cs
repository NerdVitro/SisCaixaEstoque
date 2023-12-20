using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCaixaEstoque.Formularios.Base
{
    public partial class FrmGerenciarCadastroBase : FrmBaseVazio
    {
        public FrmGerenciarCadastroBase()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Adicionar();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public virtual void Adicionar()
        {

        }
        public virtual void Editar()
        {

        }
        public virtual void Filtrar()
        {

        }
    }
}
