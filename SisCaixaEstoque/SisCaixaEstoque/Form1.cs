using SisCaixaEstoque.Classes;

namespace SisCaixaEstoque
{
    public partial class Form1 : Form
    {
        private readonly ValidacaoLogin _ObjValidacaoLogin;

        public DialogResult Resultado = DialogResult.Cancel;
        public ValidacaoLogin.NivelAcesso NivelUsuario = ValidacaoLogin.NivelAcesso.NenhumAcesso;

        public Form1()
        {
            InitializeComponent();
            _ObjValidacaoLogin = new();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_ObjValidacaoLogin.Validar(TxbLogin.Text, TxbSenha.Text))
                {
                    MessageBox.Show(_ObjValidacaoLogin.Mensagem, "Aten��o!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxbLogin.Focus();
                }
                else
                {
                    NivelUsuario = _ObjValidacaoLogin.GetNivelAcesso(TxbLogin.Text, TxbSenha.Text);
                    Resultado = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TxbSenha.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TxbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void TxbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BtnEntrar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TxbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}