using SisCaixaEstoque.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCaixaEstoque.Banco.Validacoes
{
    public class BncValidacoesCadastros
    {
        public static string ValidarCliente(string parNomeCompleto, string parCPFCNPJ)
        {
            try
            {
                string ssxRetornoValidacao = string.Empty;

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT CLI.IDCLIENTE FROM TBCLIENTE AS CLI WHERE CLI.DSNOMECOMPLETO = @DSNOMECOMPLETO";

                    using SQLiteCommand comando = new(sql, conexao);
                    comando.Parameters.AddWithValue("@DSNOMECOMPLETO", parNomeCompleto);

                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows && leitor.Read())
                    {
                        ssxRetornoValidacao += "Nome do cliente já cadastrado";
                    }

                    string sql2 = $@"SELECT CLI.IDCLIENTE FROM TBCLIENTE AS CLI WHERE CLI.VLCPFCNPJ = @VLCPFCNPJ";
                    using SQLiteCommand comando2 = new(sql2, conexao);
                    comando2.Parameters.AddWithValue("@VLCPFCNPJ", parCPFCNPJ);

                    using SQLiteDataReader leitor2 = comando2.ExecuteReader();

                    if (leitor2.HasRows && leitor2.Read())
                    {
                        ssxRetornoValidacao += "\nCPF já cadastrado";
                    }
                }

                return ssxRetornoValidacao;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string ValidarFuncionario(string parNomeCompleto, string parCPFCNPJ)
        {
            try
            {
                string ssxRetornoValidacao = string.Empty;

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT FUN.IDFUNCIONARIO FROM TBFUNCIONARIO AS FUN WHERE FUN.DSNOMECOMPLETO = @DSNOMECOMPLETO";

                    using SQLiteCommand comando = new(sql, conexao);
                    comando.Parameters.AddWithValue("@DSNOMECOMPLETO", parNomeCompleto);

                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows && leitor.Read())
                    {
                        ssxRetornoValidacao += "Nome do funcionario já cadastrado";
                    }

                    string sql2 = $@"SELECT FUN.IDFUNCIONARIO FROM TBFUNCIONARIO AS FUN WHERE FUN.VLCPFCNPJ = @VLCPFCNPJ";
                    using SQLiteCommand comando2 = new(sql2, conexao);
                    comando2.Parameters.AddWithValue("@VLCPFCNPJ", parCPFCNPJ);

                    using SQLiteDataReader leitor2 = comando2.ExecuteReader();

                    if (leitor2.HasRows && leitor2.Read())
                    {
                        ssxRetornoValidacao += "\nCPF já cadastrado";
                    }
                }

                return ssxRetornoValidacao;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
