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
    public partial class FrmCadastroBase : FrmBaseVazio
    {
        public bool BlxIsInsert = true;

        public FrmCadastroBase()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            try
            {
                if (BlxIsInsert && VerificarTextBoxesPreenchidos(PnlDados))
                {
                    if (MessageBox.Show("Tem certeza que deseja sair? \nTodos os dados inseridos serão perdidos.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual void Salvar()
        {

        }

        public bool VerificarTextBoxesPreenchidos(Control controle)
        {
            try
            {
                foreach (Control subControle in controle.Controls)
                {
                    if (subControle is TextBox textBox && !string.IsNullOrEmpty(textBox.Text))
                    {
                        return true;
                    }

                    if (subControle is Panel panel)
                    {
                        if (VerificarTextBoxesPreenchidos(panel))
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
