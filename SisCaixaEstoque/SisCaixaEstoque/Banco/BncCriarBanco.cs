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
                string sql = @"
                    -- Criação da Tabela TBCLIENTE
                    CREATE TABLE IF NOT EXISTS TBCLIENTE (
                        IDCLIENTE INTEGER PRIMARY KEY,
                        DSNOMECOMPLETO TEXT,
                        VLCPFCNPJ TEXT,
                        DSENDERECO TEXT,
                        DSCIDADE TEXT,
                        DSESTADO TEXT,
                        DSEMAIL TEXT,
                        VLTELEFONE TEXT,
                        VLCELULAR TEXT,
                        VLWHATS TEXT
                    );

                    -- Criação da Tabela TBFORNECEDOR
                    CREATE TABLE IF NOT EXISTS TBFORNECEDOR (
                        IDFORNECEDOR INTEGER PRIMARY KEY,
                        DSNOMECOMPLETO TEXT,
                        DSNOMEFANTASIA TEXT,
                        VLCNPJ TEXT,
                        DSENDERECO TEXT,
                        DSCIDADE TEXT,
                        DSESTADO TEXT,
                        DSEMAIL TEXT,
                        VLTELEFONE TEXT,
                        VLCELULAR TEXT
                    );

                    -- Criação da Tabela TBFUNCIONARIO
                    CREATE TABLE IF NOT EXISTS TBFUNCIONARIO (
                        IDFUNCIONARIO INTEGER PRIMARY KEY,
                        DSNOMECOMPLETO TEXT,
                        VLCPFCNPJ TEXT,
                        DSENDERECO TEXT,
                        DSCIDADE TEXT,
                        DSESTADO TEXT,
                        DSEMAIL TEXT,
                        VLTELEFONE TEXT,
                        VLCELULAR TEXT,
                        VLWHATS TEXT
                    );

                    -- Criação da Tabela TBPRODUTO
                    CREATE TABLE IF NOT EXISTS TBPRODUTO (
                        IDPRODUTO INTEGER PRIMARY KEY,
                        DSNOMEPRODUTO TEXT
                    );

                    -- Criação da Tabela TBVENDA
                    CREATE TABLE IF NOT EXISTS TBVENDA (
                        IDVENDA INTEGER PRIMARY KEY,
                        IDCLIENTE INTEGER,
                        VLVALORVENDA REAL,
                        DSANOTACAO TEXT,
                        FOREIGN KEY (IDCLIENTE) REFERENCES TBCLIENTE(IDCLIENTE)
                    );

                    -- Criação da Tabela TBCAIXA
                    CREATE TABLE IF NOT EXISTS TBCAIXA (
                        IDCAIXA INTEGER PRIMARY KEY,
                        IDFUNCIONARIO INTEGER,
                        VLVALORCOMECO REAL,
                        VLVALORFINAL REAL,
                        STSTATUS TEXT,
                        FOREIGN KEY (IDFUNCIONARIO) REFERENCES TBFUNCIONARIO(IDFUNCIONARIO)
                    );

                    -- Criação da Tabela TBMOVCAIXA
                    CREATE TABLE IF NOT EXISTS TBMOVCAIXA (
                        IDMOVCAIXA INTEGER PRIMARY KEY,
                        IDCAIXA INTEGER,
                        IDVENDA INTEGER,
                        FOREIGN KEY (IDCAIXA) REFERENCES TBCAIXA(IDCAIXA),
                        FOREIGN KEY (IDVENDA) REFERENCES TBVENDA(IDVENDA)
                    );

                    -- Criação da Tabela TBCARVENDA
                    CREATE TABLE IF NOT EXISTS TBCARVENDA (
                        IDCARRINHO INTEGER PRIMARY KEY,
                        IDVENDA INTEGER,
                        IDPRODUTO INTEGER,
                        FOREIGN KEY (IDVENDA) REFERENCES TBVENDA(IDVENDA),
                        FOREIGN KEY (IDPRODUTO) REFERENCES TBPRODUTO(IDPRODUTO)
                    );

                    -- Criação da Tabela TBPAGAMENTO
                    CREATE TABLE IF NOT EXISTS TBPAGAMENTO (
                        IDPAGAMENTO INTEGER PRIMARY KEY,
                        IDVENDA INTEGER,
                        VLVALORPAGO REAL,
                        VLVALORTROCO REAL,
                        TPTIPOPAG TEXT,
                        FOREIGN KEY (IDVENDA) REFERENCES TBVENDA(IDVENDA)
                    );

                    -- Criação da Tabela TBESTOQUE
                    CREATE TABLE IF NOT EXISTS TBESTOQUE (
                        IDESTOQUE INTEGER PRIMARY KEY,
                        IDPRODUTO INTEGER,
                        IDFORNECEDOR INTEGER,
                        CDCODPRODUTO INTEGER,
                        DSLOTE TEXT,
                        VLVALORCOMPRA REAL,
                        VLVALORVENDA REAL,
                        VLQUANTIDADE REAL,
                        FOREIGN KEY (IDFORNECEDOR) REFERENCES TBFORNECEDOR(IDFORNECEDOR),
                        FOREIGN KEY (IDPRODUTO) REFERENCES TBPRODUTO(IDPRODUTO)
                    );

                    CREATE TABLE IF NOT EXISTS TBUSUARIO (
                            IDUSUARIO INTEGER PRIMARY KEY AUTOINCREMENT,
                            IDFUNCIONARIO INTEGER,
                            NOME TEXT,
                            SENHA TEXT,
                            NIVEL INTEGER CHECK(NIVEL >= 0 AND NIVEL <= 5),
                            FOREIGN KEY (IDFUNCIONARIO) REFERENCES TBFUNCIONARIO(IDFUNCIONARIO)
                    );

                    INSERT INTO TBFUNCIONARIO 
                    (DSNOMECOMPLETO, VLCPFCNPJ, DSENDERECO, DSCIDADE, DSESTADO, DSEMAIL, VLTELEFONE, VLCELULAR, VLWHATS)
                    VALUES ('Admin', '123.123.123-12', 'Endereco', 'Cidade', 'Estado', 'Email', '(99) 99999-9999', '(99) 99999-9999', '(99) 99999-9999');
                    
                    INSERT INTO TBUSUARIO (IDFUNCIONARIO, NOME, SENHA, NIVEL ) 
                    VALUES (1, 'admin', '123', 3); ";

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
