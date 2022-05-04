namespace Projeto.Tests.Calculadora
{
    public class Calculadora : ICalculadora
    {
        public int Soma(int operador1, int operador2)
        {
            return operador1 + operador2;
        }
        public int Subtracao(int operador1, int operador2)
        {
            return operador1 - operador2;
        }
        public int Multiplicacao(int operador1, int operador2)
        {
            return operador1 * operador2;
        }
        public int Divisao(int dividendo, int divisor)
        {
            return dividendo / divisor;
        }
        public RestoDivisao RestoDivisao(int dividendo, int divisor)
        {
            var resultDividendo = dividendo / divisor;
            var resultDivisor = dividendo % divisor;

            var result = new RestoDivisao(resultDividendo, resultDivisor);

            return result;
        }
    }
    public interface ICalculadora
    {
        int Soma(int operador1, int operador2);
        int Subtracao(int operador1, int operador2);
        int Multiplicacao(int operador1, int operador2);
        int Divisao(int dividendo, int divisor);
        RestoDivisao RestoDivisao(int dividendo, int divisor);
    }
    public class RestoDivisao
    {
        public int Quociente { get; set; }
        public int Resto { get; set; }

        public RestoDivisao(int quociente, int resto)
        {
            Quociente = quociente;
            Resto = resto;
        }
    }
}
