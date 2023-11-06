using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCaixaEstoque.Formularios
{
    public partial class FrmPagamento : Form
    {
        public DialogResult Result = DialogResult.Cancel;

        public FrmPagamento()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Result = DialogResult.OK;
            this.Close();
        }
    }
}
