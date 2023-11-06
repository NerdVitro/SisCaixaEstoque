using SisCaixaEstoque.Formularios;

namespace SisCaixaEstoque
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Form1 login = new();
            login.ShowDialog();
            if (login.Resultado == DialogResult.OK)
            {
                //Verificar se caixa já esta aberto e não foi fechado.

                MessageBox.Show("Caixa aberto!!!");
                Application.Run(new FrmPrincipal());
            }
        }
    }
}