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
        public static void SalvarCliente(string parNomeCompleto, string parCPFCNPJ, string parEndereco, string parCidade, string parEstado, string parEmail, string parTelefone, string parCelular, string parWhatsapp)
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();
                string sql = @"INSERT INTO TBCLIENTE (
                                    DSNOMECOMPLETO,
                                    VLCPFCNPJ,
                                    DSENDERECO,
                                    DSCIDADE,
                                    DSESTADO,
                                    DSEMAIL,
                                    VLTELEFONE,
                                    VLCELULAR,
                                    VLWHATS)
                                VALUES (
                                    @DSNOMECOMPLETO,
                                    @VLCPFCNPJ,
                                    @DSENDERECO,
                                    @DSCIDADE,
                                    @DSESTADO,
                                    @DSEMAIL,
                                    @VLTELEFONE,
                                    @VLCELULAR,
                                    @VLWHATS)";

                using SQLiteCommand comando = new(sql, conexao);
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
            catch (Exception)
            {
                throw;
            }
        }
        public static void SalvarFornecedor(string parNomeCompleto, string parNomeFanasia, string parCNPJ, string parEndereco, string parCidade, string parEstado, string parEmail, string parTelefone, string parCelular)
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();
                string sql = @"INSERT INTO TBFORNECEDOR (
                                        DSNOMECOMPLETO,
                                        DSNOMEFANTASIA,
                                        VLCNPJ,
                                        DSENDERECO,
                                        DSCIDADE,
                                        DSESTADO,
                                        DSEMAIL,
                                        VLTELEFONE,
                                        VLCELULAR)
                                    VALUES (
                                        @DSNOMECOMPLETO,
                                        @DSNOMEFANTASIA,
                                        @VLCNPJ,
                                        @DSENDERECO,
                                        @DSCIDADE,
                                        @DSESTADO,
                                        @DSEMAIL,
                                        @VLTELEFONE,
                                        @VLCELULAR)";

                using SQLiteCommand comando = new(sql, conexao);
                comando.Parameters.AddWithValue("@DSNOMECOMPLETO", parNomeCompleto);
                comando.Parameters.AddWithValue("@DSNOMEFANTASIA", parNomeFanasia);
                comando.Parameters.AddWithValue("@VLCNPJ", parCNPJ);
                comando.Parameters.AddWithValue("@DSENDERECO", parEndereco);
                comando.Parameters.AddWithValue("@DSCIDADE", parCidade);
                comando.Parameters.AddWithValue("@DSESTADO", parEstado);
                comando.Parameters.AddWithValue("@DSEMAIL", parEmail);
                comando.Parameters.AddWithValue("@VLTELEFONE", parTelefone);
                comando.Parameters.AddWithValue("@VLCELULAR", parCelular);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void SalvarFuncionario(string parNomeCompleto, string parCPFCNPJ, string parEndereco, string parCidade, string parEstado, string parEmail, string parTelefone, string parCelular, string parWhatsapp)
        {
            try
			{
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
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

                using SQLiteCommand comando = new(sql, conexao);
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
			catch (Exception)
			{
				throw;
            }
        }
        public static void SalvarProduto(string parNomeProduto)
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();
                string sql = @"INSERT INTO TBPRODUTO (
                                        DSNOMEPRODUTO)
                                    VALUES (
                                        @DSNOMEPRODUTO)";

                using SQLiteCommand comando = new(sql, conexao);
                comando.Parameters.AddWithValue("@DSNOMEPRODUTO", parNomeProduto);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void SalvarVenda(int parIDCLIENTE, decimal parVLVALORVENDA, string parDSANOTACAO)
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();
                string sql = @"INSERT INTO TBVENDA (
                                        IDCLIENTE,
                                        VLVALORVENDA,
                                        DSANOTACAO)
                                    VALUES (
                                        @IDCLIENTE,
                                        @VLVALORVENDA,
                                        @DSANOTACAO)";

                using SQLiteCommand comando = new(sql, conexao);
                comando.Parameters.AddWithValue("@IDCLIENTE", parIDCLIENTE);
                comando.Parameters.AddWithValue("@VLVALORVENDA", parVLVALORVENDA);
                comando.Parameters.AddWithValue("@DSANOTACAO", parDSANOTACAO);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void SalvarCaixa(int parIDFUNCIONARIO, decimal parVLVALORCOMECO, decimal parVLVALORFINAL, string parSTSTATUS)
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();
                string sql = @"INSERT INTO TBCAIXA (
                                        IDFUNCIONARIO,
                                        VLVALORCOMECO,
                                        VLVALORFINAL,
                                        STSTATUS)
                                    VALUES (
                                        @IDFUNCIONARIO,
                                        @VLVALORCOMECO,
                                        @VLVALORFINAL,
                                        @STSTATUS)";

                using SQLiteCommand comando = new(sql, conexao);
                comando.Parameters.AddWithValue("@IDFUNCIONARIO", parIDFUNCIONARIO);
                comando.Parameters.AddWithValue("@VLVALORCOMECO", parVLVALORCOMECO);
                comando.Parameters.AddWithValue("@VLVALORFINAL", parVLVALORFINAL);
                comando.Parameters.AddWithValue("@STSTATUS", parSTSTATUS);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void SalvarCaixa(int parIDCAIXA, int parIDVENDA)
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();
                string sql = @"INSERT INTO TBMOVCAIXA (
                                        IDCAIXA,
                                        IDVENDA)
                                    VALUES (
                                        @IDCAIXA,
                                        @IDVENDA)";

                using SQLiteCommand comando = new(sql, conexao);
                comando.Parameters.AddWithValue("@IDCAIXA", parIDCAIXA);
                comando.Parameters.AddWithValue("@IDVENDA", parIDVENDA);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void SalvarCarrinhoProduto(int parIDVENDA, int parIDPRODUTO)
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();
                string sql = @"INSERT INTO TBCARVENDA (
                                        IDVENDA,
                                        IDPRODUTO)
                                    VALUES (
                                        @IDVENDA,
                                        @IDPRODUTO)";

                using SQLiteCommand comando = new(sql, conexao);
                comando.Parameters.AddWithValue("@IDVENDA", parIDVENDA);
                comando.Parameters.AddWithValue("@IDPRODUTO", parIDPRODUTO);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void SalvarTipoPagamento(string parDSTIPOPAGAMENTO, decimal parVLTAXA)
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();
                string sql = @"INSERT INTO TBTIPOPAGAMENTO (
                                        DSTIPOPAGAMENTO,
                                        VLTAXA)
                                    VALUES (
                                        @DSTIPOPAGAMENTO,
                                        @VLTAXA)";

                using SQLiteCommand comando = new(sql, conexao);
                comando.Parameters.AddWithValue("@DSTIPOPAGAMENTO", parDSTIPOPAGAMENTO);
                comando.Parameters.AddWithValue("@VLTAXA", parVLTAXA);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void SalvarPagamento(int parIDVENDA, int parIDTIPOPAGAMENTO, decimal parVLVALORPAGO, decimal parVLVALORTROCO, string parTPTIPOPAG)
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();
                string sql = @"INSERT INTO TBPAGAMENTO (
                                        IDVENDA,
                                        IDTIPOPAGAMENTO,
                                        VLVALORPAGO,
                                        VLVALORTROCO,
                                        TPTIPOPAG)
                                    VALUES (
                                        @IDVENDA,
                                        @IDTIPOPAGAMENTO,
                                        @VLVALORPAGO,
                                        @VLVALORTROCO,
                                        @TPTIPOPAG)";

                using SQLiteCommand comando = new(sql, conexao);
                comando.Parameters.AddWithValue("@IDVENDA", parIDVENDA);
                comando.Parameters.AddWithValue("@IDTIPOPAGAMENTO", parIDTIPOPAGAMENTO);
                comando.Parameters.AddWithValue("@VLVALORPAGO", parVLVALORPAGO);
                comando.Parameters.AddWithValue("@VLVALORTROCO", parVLVALORTROCO);
                comando.Parameters.AddWithValue("@TPTIPOPAG", parTPTIPOPAG);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void SalvarEstoque(int parIDPRODUTO, int parIDFORNECEDOR, int parCDCODPRODUTO, int parDSLOTE, decimal parVLVALORCOMPRA, decimal parVLVALORVENDA, decimal parVLQUANTIDADE)
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();
                string sql = @"INSERT INTO TBESTOQUE (
                                        IDPRODUTO,
                                        IDFORNECEDOR,
                                        CDCODPRODUTO,
                                        DSLOTE,
                                        VLVALORCOMPRA,
                                        VLVALORVENDA,
                                        VLQUANTIDADE) 
                                    VALUES (
                                        @IDPRODUTO,
                                        @IDFORNECEDOR,
                                        @CDCODPRODUTO,
                                        @DSLOTE,
                                        @VLVALORCOMPRA,
                                        @VLVALORVENDA,
                                        @VLQUANTIDADE)";

                using SQLiteCommand comando = new(sql, conexao);
                comando.Parameters.AddWithValue("@IDPRODUTO", parIDPRODUTO);
                comando.Parameters.AddWithValue("@IDFORNECEDOR", parIDFORNECEDOR);
                comando.Parameters.AddWithValue("@CDCODPRODUTO", parCDCODPRODUTO);
                comando.Parameters.AddWithValue("@DSLOTE", parDSLOTE);
                comando.Parameters.AddWithValue("@VLVALORCOMPRA", parVLVALORCOMPRA);
                comando.Parameters.AddWithValue("@VLVALORVENDA", parVLVALORVENDA);
                comando.Parameters.AddWithValue("@VLQUANTIDADE", parVLQUANTIDADE);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void SalvarUsuario(string parNome)
        {
            try
            {
                using SQLiteConnection conexao = new("Data Source=" + ConstantesSistema.DataSource + ";");
                conexao.Open();
                string sql = @"INSERT INTO TBUSUARIO 
                                        (NOME, 
                                        SENHA,
                                        NIVEL)
                                    VALUES 
                                        (@NOME, 
                                        '1234',
                                        1);";

                using SQLiteCommand comando = new(sql, conexao);
                comando.Parameters.AddWithValue("@NOME", parNome);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
