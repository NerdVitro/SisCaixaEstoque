using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCaixaEstoque.Classes
{
    public class AjustarGrid
    {
        //public void AdicionarColuna()
        //{

        //}

        public void Ajustar(ref DataGridView parDataGridView, object parDataSource)
        {
            parDataGridView.AllowUserToDeleteRows = false;
            parDataGridView.AllowUserToOrderColumns = false;
            parDataGridView.AllowUserToResizeColumns = false;
            parDataGridView.AllowUserToAddRows = false;
            parDataGridView.AllowDrop = false;

            parDataGridView.RowHeadersVisible = false;

            parDataGridView.DataSource = parDataSource;
        }
    }
}
