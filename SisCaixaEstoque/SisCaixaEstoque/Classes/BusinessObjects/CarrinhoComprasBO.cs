using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCaixaEstoque.Classes.BusinessObjects
{
    public class CarrinhoComprasBO
    {
        private string _NomeProduto;
        private decimal _VLQUANTIDADE;
        private decimal _PrecoProduto;
        private decimal _PrecoProdutoTotal;
        private decimal _IDPRODUTO;

        public string NomeProduto { get => _NomeProduto; set => _NomeProduto = value; }
        public decimal VLQUANTIDADE { get => _VLQUANTIDADE; set => _VLQUANTIDADE = value; }
        public decimal PrecoProduto { get => _PrecoProduto; set => _PrecoProduto = value; }
        public decimal PrecoProdutoTotal { get => _PrecoProdutoTotal; set => _PrecoProdutoTotal = value; }
        public decimal IDPRODUTO { get => _IDPRODUTO; set => _IDPRODUTO = value; }

        public CarrinhoComprasBO(string nomeProduto, decimal vLQUANTIDADE, decimal precoProduto, decimal precoProdutoTotal, decimal iDPRODUTO)
        {
            _NomeProduto = nomeProduto;
            _VLQUANTIDADE = vLQUANTIDADE;
            _PrecoProduto = precoProduto;
            _PrecoProdutoTotal = precoProdutoTotal;
            _IDPRODUTO = iDPRODUTO;
        }
        public CarrinhoComprasBO()
        {
            _NomeProduto = "";
        }
    }
}
