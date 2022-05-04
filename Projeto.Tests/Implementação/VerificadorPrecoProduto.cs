using Projeto.Tests.Domain.Models;

namespace Projeto.Tests.Implementação
{
    public class VerificadorPrecoProduto : IVerificadorPrecoProduto
    {
        public string VerificaPrecoProduto(ProdutoEntiy produtoEntiy)
        {
            if (produtoEntiy.Preco > 100)
                return "Produto caro!";
            else if (produtoEntiy.Preco <= 100 && produtoEntiy.Preco > 40)
                return "Produto na média de preço!";
            else
                return "Produto barato!";
        }
    }
}
