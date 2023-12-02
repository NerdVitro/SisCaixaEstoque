using SisCaixaEstoque.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCaixaEstoque.Banco
{
    public class BncCriarBanco
    {
        public static void Criar()
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();

                // Comando SQL com parâmetros
                string sql = @"CREATE TABLE IF NOT EXISTSUSUARIO (
                                    IDUSUARIO INTEGER PRIMARY KEY AUTOINCREMENT,
                                    NOME TEXT NOT NULL,
                                    SENHA TEXT NOT NULL,
                                    NIVEL INTEGER CHECK(NIVEL >= 0 AND NIVEL <= 5));

                                INSERT INTO USUARIO (NOME, SENHA, NIVEL ) 
                                VALUES ('admin', '123', 3)";

                // Criar o objeto do comando
                using (SQLiteCommand comando = new(sql, conexao))
                {
                    comando.ExecuteNonQuery();
                }
                conexao.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
