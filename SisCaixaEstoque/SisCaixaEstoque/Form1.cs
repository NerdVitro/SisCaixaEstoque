namespace SisCaixaEstoque
{
    public partial class Form1 : Form
    {
        public DialogResult Resultado = DialogResult.Cancel;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Resultado = DialogResult.OK;
            this.Close();
        }
    }
}