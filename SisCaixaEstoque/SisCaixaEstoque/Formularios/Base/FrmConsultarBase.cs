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
        public int ID { get; set; }
        public string DESCRICAO { get; set; }

        public FrmConsultarBase()
        {
            InitializeComponent();
            DESCRICAO = "";
        }

        protected virtual void BtnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        protected virtual void BtnAdicinar_Click(object sender, EventArgs e)
        {
            Adicionar();
        }


        public virtual void Consultar()
        {

        }
        public virtual void Adicionar()
        {

        }

        public virtual void Selecionar(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void SelecionarItemByID(DataGridViewCellEventArgs e, string parID, string parDescricao)
        {
            try
            {
                if (parDescricao is null)
                {
                    throw new(nameof(parDescricao));
                }

                if (e.ColumnIndex == DgvDados.Columns[parID].Index + 1)
                {
                    ID = Convert.ToInt32(DgvDados.Rows[e.RowIndex].Cells[parID].Value);
#pragma warning disable CS8601 // Possível atribuição de referência nula.
                    DESCRICAO = Convert.ToString(DgvDados.Rows[e.RowIndex].Cells[parDescricao].Value);
#pragma warning restore CS8601 // Possível atribuição de referência nula.
                    Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Selecionar(sender, e)
;            }
        }
    }
}
