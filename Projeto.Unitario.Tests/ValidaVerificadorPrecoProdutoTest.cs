using Moq;
using Projeto.Tests.Domain.Models;
using Projeto.Tests.Implementação;
using Xunit;

namespace Projeto.Unitario.Tests
{
    public class ValidaVerificadorPrecoProdutoTest
    {
        private readonly Mock<IVerificadorPrecoProduto> mock = new Mock<IVerificadorPrecoProduto>();
        private readonly ProdutoEntiy produtoBarato = null;
        private readonly string _doubleRetornoValor = "Produto barato!";

        public ValidaVerificadorPrecoProdutoTest()
        {
            //se alterar o preço para 55 o teste quebra, assim valida o teste feito.
            produtoBarato = new ProdutoEntiy { Preco = 35 };

            mock.Setup(m => m.VerificaPrecoProduto(produtoBarato)).Returns(_doubleRetornoValor);
        }

        [Fact(DisplayName = "ValidaVerificadorPrecoProduto")]
        public void ValidaVerificadorPrecoProduto()
        {
            var verif = new VerificadorPrecoProduto();

            var resultadoEsperado = mock.Object.VerificaPrecoProduto(produtoBarato);
            var resultado = verif.VerificaPrecoProduto(produtoBarato);

            Assert.Equal(resultado, resultadoEsperado);
        }
    }
}
