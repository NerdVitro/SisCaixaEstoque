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
