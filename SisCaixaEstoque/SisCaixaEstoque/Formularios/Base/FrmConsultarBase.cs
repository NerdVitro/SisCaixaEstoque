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
    public partial class FrmConsultarBase : FrmBaseVazio
    {
        public FrmConsultarBase()
        {
            InitializeComponent();
        }

        protected virtual void BtnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        protected virtual void BtnAdicinar_Click(object sender, EventArgs e)
        {
            Adicionar();
        }


        public void Consultar()
        {

        }
        public void Adicionar()
        {

        }
    }
}
