using SisCaixaEstoque.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCaixaEstoque.Banco.Cadastros
{
    public class BncUpdate
    {
        public static void UpdateAlterarEstoque(int parIDPRODUTO, int parVLQUANTIDADE, bool parAumentar)
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();
                string aumento = parAumentar ? "+" : "-";
                string sql = $@"UPDATE TBESTOQUE SET VLQUANTIDADE = VLQUANTIDADE {aumento} @VLQUANTIDADE WHERE IDPRODUTO = @IDPRODUTO";

                using SQLiteCommand comando = new(sql, conexao);
                comando.Parameters.AddWithValue("@IDPRODUTO", parIDPRODUTO);
                comando.Parameters.AddWithValue("@VLQUANTIDADE", parVLQUANTIDADE);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
