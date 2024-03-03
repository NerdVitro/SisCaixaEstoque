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

        public static string ValidarFornecedor(string parNomeCompleto, string parNomeFantasia, string parCPFCNPJ)
        {
            try
            {
                string ssxRetornoValidacao = string.Empty;

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT FORN.IDFORNECEDOR FROM TBFORNECEDOR AS FORN WHERE FORN.DSNOMECOMPLETO = @DSNOMECOMPLETO";

                    using SQLiteCommand comando = new(sql, conexao);
                    comando.Parameters.AddWithValue("@DSNOMECOMPLETO", parNomeCompleto);

                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows && leitor.Read())
                    {
                        ssxRetornoValidacao += "Nome já cadastrado";
                    }

                    sql = $@"SELECT FORN.IDFORNECEDOR FROM TBFORNECEDOR AS FORN WHERE FORN.DSNOMEFANTASIA = @DSNOMEFANTASIA";
                    using SQLiteCommand comando2 = new(sql, conexao);
                    comando2.Parameters.AddWithValue("@DSNOMEFANTASIA", parCPFCNPJ);

                    using SQLiteDataReader leitor2 = comando2.ExecuteReader();

                    if (leitor2.HasRows && leitor2.Read())
                    {
                        ssxRetornoValidacao += "\nNome Fantasia já cadastrado";
                    }

                    sql = $@"SELECT FORN.IDFORNECEDOR FROM TBFORNECEDOR AS FORN WHERE FORN.VLCNPJ = @VLCNPJ";
                    using SQLiteCommand comando3 = new(sql, conexao);
                    comando3.Parameters.AddWithValue("@VLCNPJ", parCPFCNPJ);

                    using SQLiteDataReader leitor3 = comando3.ExecuteReader();

                    if (leitor3.HasRows && leitor3.Read())
                    {
                        ssxRetornoValidacao += "\nCNPJ já cadastrado";
                    }
                }

                return ssxRetornoValidacao;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string ValidarProduto(string parProduto)
        {
            try
            {
                string ssxRetornoValidacao = string.Empty;

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT PRO.IDPRODUTO FROM TBPRODUTO AS PRO WHERE PRO.DSNOMEPRODUTO = @DSNOMEPRODUTO";

                    using SQLiteCommand comando = new(sql, conexao);
                    comando.Parameters.AddWithValue("@DSNOMEPRODUTO", parProduto);

                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows && leitor.Read())
                    {
                        ssxRetornoValidacao += "Produto já cadastrado";
                    }
                }

                return ssxRetornoValidacao;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string ValidarTipoPagamento(string parTipoPagamento)
        {
            try
            {
                string ssxRetornoValidacao = string.Empty;

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT FOR.IDTIPOPAGAMENTO FROM TBTIPOPAGAMENTO AS FOR WHERE FOR.DSTIPOPAGAMENTO = @DSTIPOPAGAMENTO";

                    using SQLiteCommand comando = new(sql, conexao);
                    comando.Parameters.AddWithValue("@DSTIPOPAGAMENTO", parTipoPagamento);

                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows && leitor.Read())
                    {
                        ssxRetornoValidacao += "Tipo de pagamento já cadastrado";
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
