using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCaixaEstoque.Classes
{
    public static class AjustarGrid
    {



        public static void Ajustar(ref DataGridView parDataGridView)
        {
            parDataGridView.AllowUserToDeleteRows = false;
            parDataGridView.AllowUserToOrderColumns = false;
            parDataGridView.AllowUserToResizeColumns = false;
            parDataGridView.AllowUserToAddRows = false;
            parDataGridView.AllowDrop = false;


        }
    }
}
