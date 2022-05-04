using Projeto.Tests.Calculadora;
using Projeto.Tests.Domain.Models;
using Projeto.Tests.Implementação;
using System;

namespace Projeto.Tests
{
    class Program
    {
        /* 
         * IMPORTANTE
         * O INTUITO DESSE PROJETO É MOSTRAR DE FORMA CLARA COMO FUNCIONA OS TESTE UNITÁRIOS 
         * NÃO SENDO LEVADO EM CONSIDERAÇÃO QUALQUER TIPO DE ARQUITEURA. FOCADO APENAS NOS TESTES
         * [INSTRUÇOES]:
         *   1: CLICAR COM O BOTÃO DIRETIRO EM CIMA DO PROJETO PROJETO.UNITARIO.TESTS
         *   2: ESCOLHER A OPÇÃO EXECUTAR TESTES UNITÁRIOS
         *   3: IR EM GERENCIADOR DE TESTES E ANALISAR A EXECUÇÃO
         * BY: ATYLLA MACEDO ALVES CRUS :)
         */
        static void Main(string[] args)
        {
            ExecucaoCalculador();

            ExecutaVerificacaoProduto();
        }

        private static void ExecucaoCalculador()
        {
            ICalculadora calculadora = new Projeto.Tests.Calculadora.Calculadora();
            var soma = calculadora.Soma(1, 2);
            var divisao = calculadora.Divisao(10, 2);
            var multiplicacao = calculadora.Multiplicacao(3, 3);
            var subtracao = calculadora.Subtracao(10, 5);
            var restoDivisao = calculadora.RestoDivisao(10, 2);
        }
        private static void ExecutaVerificacaoProduto()
        {
            IVerificadorPrecoProduto verificadorPrecoProduto = new VerificadorPrecoProduto();

            var resultado = verificadorPrecoProduto.VerificaPrecoProduto(new ProdutoEntiy(1, "Teste.Ti", "Produto Teste", 100));

            Console.WriteLine($"Resultado: {resultado}");

            Console.ReadKey();
        }
    }
}
