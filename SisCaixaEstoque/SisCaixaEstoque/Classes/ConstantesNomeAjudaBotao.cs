using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCaixaEstoque.Classes
{
    public static class ConstantesNomeAjudaBotao
    {
        public readonly struct TelaInicial
        {
            public static string BotaoCaixa { get; } = "Abrir tela \nCaixa";
            public static string BotaoCliente { get; } = "Abrir tela \nClientes";
            public static string BotaoProduto { get; } = "Abrir tela \nProduto";
            public static string BotaoEstoque { get; } = "Abrir tela \nEstoque";
            public static string BotaoConfiguracao { get; } = "Abrir tela \nConfiguração";
            public static string BotaoSair { get; } = "Sair do Sistema";
            public static string BotaoFinalizar { get; } = "Finalizar a venda, ir para a \ntela de lançamento de pagamento";
            public static string BotaoExcluirItemLinha { get; } = "Retirar Item do carrinho";
        }

        public readonly struct TelaConfiguracao
        {
            public static string BotaoFuncionario { get; } = "Abrir tela \nFuncionário";
            public static string BtnFormaPagamento { get; } = "Abrir tela \nForma Pagamento";
            public static string BtnFornecedor { get; } = "Abrir tela \nnFornecedor";
        }
    }
}
