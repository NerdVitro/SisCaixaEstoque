using SisCaixaEstoque.Classes;
using System.Data.SQLite;

namespace SisCaixaEstoque.Banco
{
    public class BncValidarLogin
    {
        public static bool ValidarLogin(string parLogin, string parSenha)
        {
			try
			{
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();

                // Criar o objeto do comando
                using (SQLiteCommand comando = new("SELECT name FROM sqlite_master WHERE type='table' AND name='TBUSUARIO'", conexao))
                {
                    if (comando.ExecuteScalar() == null)
                    {
                        if (parLogin == "admin" && parSenha == "123")
                        {
                            BncCriarBanco.Criar();
                            return true;
                        }
                    }
                    else
                    {
                        using SQLiteCommand comando1 = new("SELECT SENHA FROM TBUSUARIO WHERE NOME = @NOME;", conexao);
                        comando1.Parameters.AddWithValue("@NOME", parLogin);
                        using SQLiteDataReader leitor = comando1.ExecuteReader();
                        if (leitor.Read())
                            return Convert.ToString(leitor["SENHA"]) == parSenha;
                    }
                }
                conexao.Close();
                return false;
			}
			catch (Exception)
			{
				throw;
			}
        }
        public static int GetNivelAcesso(string parLogin, string parSenha)
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();

                using (SQLiteCommand comando = new("SELECT NIVEL FROM TBUSUARIO WHERE NOME = @NOME AND SENHA = @SENHA;", conexao))
                {
                    comando.Parameters.AddWithValue("@NOME", parLogin);
                    comando.Parameters.AddWithValue("@SENHA", parSenha);
                    using SQLiteDataReader leitor = comando.ExecuteReader();
                    if (leitor.Read())
                        return Convert.ToInt32(leitor["NIVEL"]);
                }
                conexao.Close();
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
