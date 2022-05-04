using Projeto.Tests.Calculadora;
using Xunit;

namespace Projeto.Unitario.Tests
{
    public class CalculadoraTest
    {
        private readonly ICalculadora _calculadora;
        public CalculadoraTest()
        {
            _calculadora = new Calculadora();
        }
        [Fact]
        public void Soma_DeveRetornarOValorCorreto()
        {
            var resultado = _calculadora.Soma(10, 20);
            //Verifica se o resultado é igual a 30
            Assert.Equal(30, resultado);
        }

        [Fact]
        public void RestoDivisao_DeveRetornarOValorCorreto()
        {
            var resultado = _calculadora.RestoDivisao(10, 3);

            //O quociente é o valor que se obtém ao dividir o dividendo pelo divisor. O quociente representa o número de vezes que o dividendo contém o divisor
            //Verifica se o quociente da divisão é 3 e o resto 1

            Assert.Equal(3, resultado.Quociente);
            Assert.Equal(1, resultado.Resto);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void RestoDivisao_DeveRetornarZero(int value)
        {
            var resultado = _calculadora.RestoDivisao(12, value);
            //Verifica se o resto da divisão é 0
            Assert.Equal(0, resultado.Resto);
        }

        [Fact]
        public void Subtracao_DeveRetornarOValorCorreto()
        {
            var resultado = _calculadora.Subtracao(20, 10);
            //Verifica se o resultado é igual a 10
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void Divisao_DeveRetornarOValorCorreto()
        {

            var resultado = _calculadora.Divisao(100, 10);
            //Verifica se o resultado é igual a 10
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void Multiplicacao_DeveRetornarOValorCorreto()
        {
            var resultado = _calculadora.Multiplicacao(5, 2);
            //Verifica se o resultado é igual a 10
            Assert.Equal(10, resultado);
        }
    }
}
