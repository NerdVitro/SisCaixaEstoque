using SisCaixaEstoque.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCaixaEstoque.Banco.Cadastros
{
    public class BncInserts
    {




        public static void SalvarFuncionario(string parNomeCompleto, string parCPFCNPJ, string parEndereco, string parCidade, string parEstado, string parEmail, string parTelefone, string parCelular, string parWhatsapp)
        {
            SQLiteConnection conexao = null;
            try
			{
                using (conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = @"INSERT INTO TBFUNCIONARIO 
                                        (DSNOMECOMPLETO, 
                                        VLCPFCNPJ, 
                                        DSENDERECO, 
                                        DSCIDADE, 
                                        DSESTADO, 
                                        DSEMAIL, 
                                        VLTELEFONE, 
                                        VLCELULAR, 
                                        VLWHATS)
                                    VALUES 
                                        (@DSNOMECOMPLETO, 
                                        @VLCPFCNPJ, 
                                        @DSENDERECO, 
                                        @DSCIDADE, 
                                        @DSESTADO, 
                                        @DSEMAIL, 
                                        @VLTELEFONE, 
                                        @VLCELULAR, 
                                        @VLWHATS);";
                    
                    
                    
                    using (SQLiteCommand comando = new(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@DSNOMECOMPLETO", parNomeCompleto);
                        comando.Parameters.AddWithValue("@VLCPFCNPJ", parCPFCNPJ);
                        comando.Parameters.AddWithValue("@DSENDERECO", parEndereco);
                        comando.Parameters.AddWithValue("@DSCIDADE", parCidade);
                        comando.Parameters.AddWithValue("@DSESTADO", parEstado);
                        comando.Parameters.AddWithValue("@DSEMAIL", parEmail);
                        comando.Parameters.AddWithValue("@VLTELEFONE", parTelefone);
                        comando.Parameters.AddWithValue("@VLCELULAR", parCelular);
                        comando.Parameters.AddWithValue("@VLWHATS", parWhatsapp);
                        comando.ExecuteNonQuery();
                        
                    }
                }
            }
			catch (Exception)
			{
				throw;
            }
            finally
            {
                conexao?.Close();
            }
        }
        public static void SalvarUsuario(string parNomeCompleto)
        {
            SQLiteConnection conexao = null;
            try
            {
                using (conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = @"INSERT INTO TBFUNCIONARIO 
                                        (DSNOMECOMPLETO, 
                                        VLWHATS)
                                    VALUES 
                                        (@DSNOMECOMPLETO, 
                                        '1234');";



                    using (SQLiteCommand comando = new(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@DSNOMECOMPLETO", parNomeCompleto);
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao?.Close();
            }
        }
    }
}
