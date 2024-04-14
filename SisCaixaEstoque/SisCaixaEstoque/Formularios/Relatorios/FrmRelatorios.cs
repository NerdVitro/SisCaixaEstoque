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
    public partial class FrmRelatorios : FrmBaseVazio
    {
        public FrmRelatorios()
        {
            InitializeComponent();
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmRelatorioVendas().ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
