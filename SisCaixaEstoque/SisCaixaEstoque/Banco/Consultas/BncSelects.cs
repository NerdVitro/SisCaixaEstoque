using SisCaixaEstoque.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCaixaEstoque.Banco.Consultas
{
    public class BncSelects
    {
        public static DataTable BuscarCliente(string parWhere)
        {
            try
            {
                DataTable DataTableRetorno = new();
                DataTableRetorno.Columns.Add("IDCLIENTE", typeof(int));
                DataTableRetorno.Columns.Add("DSNOMECOMPLETO", typeof(string));
                DataTableRetorno.Columns.Add("VLCPFCNPJ", typeof(string));
                DataTableRetorno.Columns.Add("DSENDERECO", typeof(string));
                DataTableRetorno.Columns.Add("DSCIDADE", typeof(string));
                DataTableRetorno.Columns.Add("DSESTADO", typeof(string));
                DataTableRetorno.Columns.Add("DSEMAIL", typeof(string));
                DataTableRetorno.Columns.Add("VLTELEFONE", typeof(string));
                DataTableRetorno.Columns.Add("VLCELULAR", typeof(string));
                DataTableRetorno.Columns.Add("VLWHATS", typeof(string));

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT 
                                        CLI.IDCLIENTE
                                        ,CLI.DSNOMECOMPLETO
                                        ,CLI.VLCPFCNPJ
                                        ,CLI.DSENDERECO
                                        ,CLI.DSCIDADE
                                        ,CLI.DSESTADO
                                        ,CLI.DSEMAIL
                                        ,CLI.VLTELEFONE
                                        ,CLI.VLCELULAR
                                        ,CLI.VLWHATS
                                    FROM TBCLIENTE AS CLI
                                    {parWhere}";

                    using SQLiteCommand comando = new(sql, conexao);
                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows)
                    {
                        while (leitor.Read())
                        {
                            DataTableRetorno.Rows.Add(
                                Convert.ToInt32(leitor["IDCLIENTE"])
                                ,Convert.ToString(leitor["DSNOMECOMPLETO"])
                                , Convert.ToString(leitor["VLCPFCNPJ"])
                                , Convert.ToString(leitor["DSENDERECO"])
                                , Convert.ToString(leitor["DSCIDADE"])
                                , Convert.ToString(leitor["DSESTADO"])
                                , Convert.ToString(leitor["DSEMAIL"])
                                , Convert.ToString(leitor["VLTELEFONE"])
                                , Convert.ToString(leitor["VLCELULAR"])
                                , Convert.ToString(leitor["VLWHATS"])
                                );
                        }
                    }
                }

                return DataTableRetorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable BuscarFornecedor(string parWhere)
        {
            try
            {
                DataTable DataTableRetorno = new();
                DataTableRetorno.Columns.Add("IDFORNECEDOR", typeof(int));
                DataTableRetorno.Columns.Add("DSNOMEFANTASIA", typeof(string));
                DataTableRetorno.Columns.Add("DSNOMECOMPLETO", typeof(string));
                DataTableRetorno.Columns.Add("VLCNPJ", typeof(string));
                DataTableRetorno.Columns.Add("DSENDERECO", typeof(string));
                DataTableRetorno.Columns.Add("DSCIDADE", typeof(string));
                DataTableRetorno.Columns.Add("DSESTADO", typeof(string));
                DataTableRetorno.Columns.Add("DSEMAIL", typeof(string));
                DataTableRetorno.Columns.Add("VLTELEFONE", typeof(string));
                DataTableRetorno.Columns.Add("VLCELULAR", typeof(string));

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT 
                                        FORN.IDFORNECEDOR,
                                        ,FORN.DSNOMECOMPLETO
                                        ,FORN.DSNOMEFANTASIA
                                        ,FORN.VLCNPJ
                                        ,FORN.DSENDERECO
                                        ,FORN.DSCIDADE
                                        ,FORN.DSESTADO
                                        ,FORN.DSEMAIL
                                        ,FORN.VLTELEFONE
                                        ,FORN.VLCELULAR
                                    FROM TBFORNECEDOR AS FORN
                                    {parWhere}";

                    using SQLiteCommand comando = new(sql, conexao);
                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows)
                    {
                        while (leitor.Read())
                        {
                            DataTableRetorno.Rows.Add(
                                Convert.ToInt32(leitor["IDFORNECEDOR"])
                                , Convert.ToString(leitor["DSNOMECOMPLETO"])
                                , Convert.ToString(leitor["DSNOMEFANTASIA"])
                                , Convert.ToString(leitor["VLCNPJ"])
                                , Convert.ToString(leitor["DSENDERECO"])
                                , Convert.ToString(leitor["DSCIDADE"])
                                , Convert.ToString(leitor["DSESTADO"])
                                , Convert.ToString(leitor["DSEMAIL"])
                                , Convert.ToString(leitor["VLTELEFONE"])
                                , Convert.ToString(leitor["VLCELULAR"])
                                );
                        }
                    }
                }

                return DataTableRetorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable BuscarFuncionario(string parWhere)
        {
            try
            {
                DataTable DataTableRetorno = new();
                DataTableRetorno.Columns.Add("IDFUNCIONARIO", typeof(int));
                DataTableRetorno.Columns.Add("DSNOMECOMPLETO", typeof(string));
                DataTableRetorno.Columns.Add("VLCPFCNPJ", typeof(string));
                DataTableRetorno.Columns.Add("DSENDERECO", typeof(string));
                DataTableRetorno.Columns.Add("DSCIDADE", typeof(string));
                DataTableRetorno.Columns.Add("DSESTADO", typeof(string));
                DataTableRetorno.Columns.Add("DSEMAIL", typeof(string));
                DataTableRetorno.Columns.Add("VLTELEFONE", typeof(string));
                DataTableRetorno.Columns.Add("VLCELULAR", typeof(string));
                DataTableRetorno.Columns.Add("VLWHATS", typeof(string));

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT 
                                        FUN.IDFUNCIONARIO
                                        ,FUN.DSNOMECOMPLETO
                                        ,FUN.VLCPFCNPJ
                                        ,FUN.DSENDERECO
                                        ,FUN.DSCIDADE
                                        ,FUN.DSESTADO
                                        ,FUN.DSEMAIL
                                        ,FUN.VLTELEFONE
                                        ,FUN.VLCELULAR
                                        ,FUN.VLWHATS 
                                    FROM TBFUNCIONARIO AS FUN
                                    {parWhere}";

                    using SQLiteCommand comando = new(sql, conexao);
                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows)
                    {
                        while (leitor.Read())
                        {
                            DataTableRetorno.Rows.Add(
                                Convert.ToInt32(leitor["IDFUNCIONARIO"])
                                , Convert.ToString(leitor["DSNOMECOMPLETO"])
                                , Convert.ToString(leitor["VLCPFCNPJ"])
                                , Convert.ToString(leitor["DSENDERECO"])
                                , Convert.ToString(leitor["DSCIDADE"])
                                , Convert.ToString(leitor["DSESTADO"])
                                , Convert.ToString(leitor["DSEMAIL"])
                                , Convert.ToString(leitor["VLTELEFONE"])
                                , Convert.ToString(leitor["VLCELULAR"])
                                , Convert.ToString(leitor["VLWHATS"])
                                );
                        }
                    }
                }

                return DataTableRetorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable BuscarProduto(string parWhere)
        {
            try
            {
                DataTable DataTableRetorno = new();
                DataTableRetorno.Columns.Add("IDPRODUTO", typeof(int));
                DataTableRetorno.Columns.Add("DSNOMEPRODUTO", typeof(string));

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT 
                                        PRO.IDPRODUTO
                                        ,PRO.DSNOMEPRODUTO
                                    FROM TBPRODUTO AS PRO
                                    {parWhere}";

                    using SQLiteCommand comando = new(sql, conexao);
                    using SQLiteDataReader leitor = comando.ExecuteReader();
                    
                    if (leitor.HasRows)
                    {
                        while (leitor.Read())
                        {
                            DataTableRetorno.Rows.Add(
                                Convert.ToInt32(leitor["IDPRODUTO"])
                                ,Convert.ToString(leitor["DSNOMEPRODUTO"]));
                        }
                    }
                }

                return DataTableRetorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable BuscarTipoPagamento(string parWhere)
        {
            try
            {
                DataTable DataTableRetorno = new();
                DataTableRetorno.Columns.Add("IDTIPOPAGAMENTO", typeof(int));
                DataTableRetorno.Columns.Add("DSTIPOPAGAMENTO", typeof(string));
                DataTableRetorno.Columns.Add("VLTAXA", typeof(Decimal));

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT 
                                        FOR.IDTIPOPAGAMENTO
                                        ,FOR.DSTIPOPAGAMENTO
                                        ,FOR.VLTAXA
                                    FROM TBTIPOPAGAMENTO AS FOR
                                    {parWhere}";

                    using SQLiteCommand comando = new(sql, conexao);
                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows)
                    {
                        while (leitor.Read())
                        {
                            DataTableRetorno.Rows.Add(
                                Convert.ToInt32(leitor["IDTIPOPAGAMENTO"])
                                , Convert.ToString(leitor["DSTIPOPAGAMENTO"])
                                , Convert.ToDecimal(leitor["VLTAXA"])
                                );
                        }
                    }
                }

                return DataTableRetorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable BuscarVenda(string parWhere)
        {
            try
            {
                DataTable DataTableRetorno = new();
                DataTableRetorno.Columns.Add("IDVENDA", typeof(int));
                DataTableRetorno.Columns.Add("IDCLIENTE", typeof(int));
                DataTableRetorno.Columns.Add("VLVALORVENDA", typeof(decimal));
                DataTableRetorno.Columns.Add("DSANOTACAO", typeof(string));
                DataTableRetorno.Columns.Add("DSNOMECOMPLETO", typeof(string));

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT 
                                        VEN.IDVENDA
                                        ,VEN.IDCLIENTE
                                        ,VEN.VLVALORVENDA
                                        ,VEN.DSANOTACAO
                                        ,CLI.DSNOMECOMPLETO
                                    FROM TBVENDA AS VEN
                                    INNER JOIN TBCLIENTE AS CLI ON CLI.IDCLIENTE = VEN.IDCLIENTE
                                    {parWhere}";

                    using SQLiteCommand comando = new(sql, conexao);
                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows)
                    {
                        while (leitor.Read())
                        {
                            DataTableRetorno.Rows.Add(
                                Convert.ToInt32(leitor["IDVENDA"])
                                , Convert.ToInt32(leitor["IDCLIENTE"])
                                , Convert.ToDecimal(leitor["VLVALORVENDA"])
                                , Convert.ToString(leitor["DSANOTACAO"])
                                , Convert.ToString(leitor["DSNOMECOMPLETO"])
                                );
                        }
                    }
                }

                return DataTableRetorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable BuscarCaixa(string parWhere)
        {
            try
            {
                DataTable DataTableRetorno = new();
                DataTableRetorno.Columns.Add("IDCAIXA", typeof(int));
                DataTableRetorno.Columns.Add("IDFUNCIONARIO", typeof(int));
                DataTableRetorno.Columns.Add("VLVALORCOMECO", typeof(decimal));
                DataTableRetorno.Columns.Add("VLVALORFINAL", typeof(decimal));
                DataTableRetorno.Columns.Add("STSTATUS", typeof(string));
                DataTableRetorno.Columns.Add("DSNOMECOMPLETO", typeof(string));

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT 
                                        CAX.IDCAIXA
                                        ,CAX.IDFUNCIONARIO
                                        ,CAX.VLVALORCOMECO
                                        ,CAX.VLVALORFINAL
                                        ,CAX.STSTATUS
                                        ,FUN.DSNOMECOMPLETO
                                    FROM TBCAIXA AS CAX
                                    INNER JOIN TBFUNCIONARIO AS FUN ON FUN.IDFUNCIONARIO = CAX.IDFUNCIONARIO
                                    {parWhere}";

                    using SQLiteCommand comando = new(sql, conexao);
                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows)
                    {
                        while (leitor.Read())
                        {
                            DataTableRetorno.Rows.Add(
                                Convert.ToInt32(leitor["IDCAIXA"])
                                , Convert.ToInt32(leitor["IDFUNCIONARIO"])
                                , Convert.ToDecimal(leitor["VLVALORCOMECO"])
                                , Convert.ToDecimal(leitor["VLVALORFINAL"])
                                , Convert.ToString(leitor["STSTATUS"])
                                , Convert.ToString(leitor["DSNOMECOMPLETO"])
                                );
                        }
                    }
                }

                return DataTableRetorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable BuscarMovmentacaoCaixa(string parWhere)
        {
            try
            {
                DataTable DataTableRetorno = new();
                DataTableRetorno.Columns.Add("IDMOVCAIXA", typeof(int));
                DataTableRetorno.Columns.Add("IDCAIXA", typeof(int));
                DataTableRetorno.Columns.Add("IDVENDA", typeof(int));
                DataTableRetorno.Columns.Add("FUNCIONARIO", typeof(string));
                DataTableRetorno.Columns.Add("CLIENTE", typeof(string));

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT 
                                        MVT.IDMOVCAIXA
                                        ,MVT.IDCAIXA
                                        ,MVT.IDVENDA
                                        ,FUN.DSNOMECOMPLETO AS FUNCIONARIO
                                        ,CLI.DSNOMECOMPLETO AS CLIENTE
                                    FROM TBMOVCAIXA AS MVT
                                    INNER JOIN TBCAIXA AS CAX ON CAX.IDCAIXA = MVT.IDCAIXA
                                    INNER JOIN TBVENDA AS VEN ON VEN.IDVENDA = MVT.IDVENDA
                                    INNER JOIN TBCLIENTE AS CLI ON CLI.IDCLIENTE = VEN.IDCLIENTE
                                    INNER JOIN TBFUNCIONARIO AS FUN ON FUN.IDFUNCIONARIO = CAX.IDFUNCIONARIO
                                    {parWhere}";

                    using SQLiteCommand comando = new(sql, conexao);
                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows)
                    {
                        while (leitor.Read())
                        {
                            DataTableRetorno.Rows.Add(
                                Convert.ToInt32(leitor["IDMOVCAIXA"])
                                , Convert.ToInt32(leitor["IDCAIXA"])
                                , Convert.ToInt32(leitor["IDVENDA"])
                                , Convert.ToString(leitor["FUNCIONARIO"])
                                , Convert.ToString(leitor["CLIENTE"])
                                );
                        }
                    }
                }

                return DataTableRetorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable BuscarCarrinhoVenda(string parWhere)
        {
            try
            {
                DataTable DataTableRetorno = new();
                DataTableRetorno.Columns.Add("IDCARRINHO", typeof(int));
                DataTableRetorno.Columns.Add("IDVENDA", typeof(int));
                DataTableRetorno.Columns.Add("IDPRODUTO", typeof(int));
                DataTableRetorno.Columns.Add("CLIENTE", typeof(string));
                DataTableRetorno.Columns.Add("DSNOMEPRODUTO", typeof(string));

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT 
                                        CAR.IDCARRINHO
                                        ,CAR.IDVENDA
                                        ,CAR.IDPRODUTO
                                        ,CLI.DSNOMECOMPLETO AS CLIENTE
                                        ,PRO.DSNOMEPRODUTO
                                    FROM TBCARVENDA AS CAR
                                    INNER JOIN TBVENDA AS VEN ON VEN.IDVENDA = CAR.IDVENDA
                                    INNER JOIN TBPRODUTO AS PRO ON PRO.IDPRODUTO = CAR.IDPRODUTO
                                    INNER JOIN TBCLIENTE AS CLI ON CLI.IDCLIENTE = VEN.IDCLIENTE
                                    {parWhere}";

                    using SQLiteCommand comando = new(sql, conexao);
                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows)
                    {
                        while (leitor.Read())
                        {
                            DataTableRetorno.Rows.Add(
                                Convert.ToInt32(leitor["IDCARRINHO"])
                                , Convert.ToInt32(leitor["IDVENDA"])
                                , Convert.ToInt32(leitor["IDPRODUTO"])
                                , Convert.ToString(leitor["CLIENTE"])
                                , Convert.ToString(leitor["DSNOMEPRODUTO"])
                                );
                        }
                    }
                }

                return DataTableRetorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable BuscarPagamento(string parWhere)
        {
            try
            {
                DataTable DataTableRetorno = new();
                DataTableRetorno.Columns.Add("IDPAGAMENTO", typeof(int));
                DataTableRetorno.Columns.Add("IDVENDA", typeof(int));
                DataTableRetorno.Columns.Add("IDTIPOPAGAMENTO", typeof(int));
                DataTableRetorno.Columns.Add("VLVALORPAGO", typeof(decimal));
                DataTableRetorno.Columns.Add("VLVALORTROCO", typeof(decimal));
                DataTableRetorno.Columns.Add("DSTIPOPAGAMENTO", typeof(string));

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT 
                                        PAG.IDPAGAMENTO
                                        ,PAG.IDVENDA
                                        ,PAG.IDTIPOPAGAMENTO
                                        ,PAG.VLVALORPAGO
                                        ,PAG.VLVALORTROCO
                                        ,TPP.DSTIPOPAGAMENTO
                                    FROM TBPAGAMENTO AS PAG
                                    INNER JOIN TBVENDA AS VEN ON VEN.IDVENDA = PAG.IDVENDA
                                    INNER JOIN TBTIPOPAGAMENTO TPP VEN ON TPP.IDTIPOPAGAMENTO = PAG.IDTIPOPAGAMENTO
                                    {parWhere}";

                    using SQLiteCommand comando = new(sql, conexao);
                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows)
                    {
                        while (leitor.Read())
                        {
                            DataTableRetorno.Rows.Add(
                                Convert.ToInt32(leitor["IDPAGAMENTO"])
                                , Convert.ToInt32(leitor["IDVENDA"])
                                , Convert.ToInt32(leitor["IDTIPOPAGAMENTO"])
                                , Convert.ToDecimal(leitor["VLVALORPAGO"])
                                , Convert.ToDecimal(leitor["VLVALORTROCO"])
                                , Convert.ToString(leitor["TPTIPOPAG"])
                                , Convert.ToString(leitor["DSTIPOPAGAMENTO"])
                                );
                        }
                    }
                }

                return DataTableRetorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable BuscarEstoque(string parWhere)
        {
            try
            {
                DataTable DataTableRetorno = new();
                DataTableRetorno.Columns.Add("IDESTOQUE", typeof(int));
                DataTableRetorno.Columns.Add("IDPRODUTO", typeof(int));
                DataTableRetorno.Columns.Add("IDFORNECEDOR", typeof(int));
                DataTableRetorno.Columns.Add("CDCODPRODUTO", typeof(string));
                DataTableRetorno.Columns.Add("DSLOTE", typeof(string));
                DataTableRetorno.Columns.Add("VLVALORCOMPRA", typeof(decimal));
                DataTableRetorno.Columns.Add("VLVALORVENDA", typeof(decimal));
                DataTableRetorno.Columns.Add("VLQUANTIDADE", typeof(decimal));
                DataTableRetorno.Columns.Add("DSNOMECOMPLETO", typeof(string));
                DataTableRetorno.Columns.Add("DSNOMEPRODUTO", typeof(string));

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT 
                                        EST.IDESTOQUE
                                        ,EST.IDPRODUTO
                                        ,EST.IDFORNECEDOR
                                        ,EST.CDCODPRODUTO
                                        ,EST.DSLOTE
                                        ,EST.VLVALORCOMPRA
                                        ,EST.VLVALORVENDA
                                        ,EST.VLQUANTIDADE
                                        ,FORN.DSNOMECOMPLETO
                                        ,PRO.DSNOMEPRODUTO
                                    FROM TBESTOQUE AS EST
                                    INNER JOIN TBFORNECEDOR AS FORN ON FORN.IDFORNECEDOR = EST.IDFORNECEDOR
                                    INNER JOIN TBPRODUTO AS PRO ON PRO.IDPRODUTO = EST.IDPRODUTO
                                    {parWhere}";

                    using SQLiteCommand comando = new(sql, conexao);
                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows)
                    {
                        while (leitor.Read())
                        {
                            DataTableRetorno.Rows.Add(
                                Convert.ToInt32(leitor["IDESTOQUE"])
                                , Convert.ToInt32(leitor["IDPRODUTO"])
                                , Convert.ToInt32(leitor["IDFORNECEDOR"])
                                , Convert.ToString(leitor["CDCODPRODUTO"])
                                , Convert.ToString(leitor["DSLOTE"])
                                , Convert.ToDecimal(leitor["VLVALORCOMPRA"])
                                , Convert.ToDecimal(leitor["VLVALORVENDA"])
                                , Convert.ToDecimal(leitor["VLQUANTIDADE"])
                                , Convert.ToString(leitor["DSNOMECOMPLETO"])
                                , Convert.ToString(leitor["DSNOMEPRODUTO"])
                                );
                        }
                    }
                }

                return DataTableRetorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable BuscarUsuario(string parWhere)
        {
            try
            {
                DataTable DataTableRetorno = new();
                DataTableRetorno.Columns.Add("IDUSUARIO", typeof(int));
                DataTableRetorno.Columns.Add("IDFUNCIONARIO", typeof(int));
                DataTableRetorno.Columns.Add("NOME", typeof(string));
                DataTableRetorno.Columns.Add("SENHA", typeof(string));
                DataTableRetorno.Columns.Add("NIVEL", typeof(int));
                DataTableRetorno.Columns.Add("DSNOMECOMPLETO", typeof(string));
                DataTableRetorno.Columns.Add("DSNOMEPRODUTO", typeof(string));

                using (SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";"))
                {
                    conexao.Open();
                    string sql = $@"SELECT 
                                        USU.IDUSUARIO
                                        ,USU.IDFUNCIONARIO
                                        ,USU.NOME
                                        ,USU.SENHA
                                        ,USU.NIVEL
                                        ,FUN.DSNOMECOMPLETO
                                    FROM TBUSUARIO AS USU
                                    INNER JOIN TBFUNCIONARIO AS FUN ON FUN.IDFUNCIONARIO = USU.IDFUNCIONARIO
                                    {parWhere}";

                    using SQLiteCommand comando = new(sql, conexao);
                    using SQLiteDataReader leitor = comando.ExecuteReader();

                    if (leitor.HasRows)
                    {
                        while (leitor.Read())
                        {
                            DataTableRetorno.Rows.Add(
                                Convert.ToInt32(leitor["IDUSUARIO"])
                                , Convert.ToInt32(leitor["IDFUNCIONARIO"])
                                , Convert.ToString(leitor["NOME"])
                                , Convert.ToString(leitor["SENHA"])
                                , Convert.ToInt32(leitor["NIVEL"])
                                , Convert.ToString(leitor["DSNOMECOMPLETO"])
                                );
                        }
                    }
                }

                return DataTableRetorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
