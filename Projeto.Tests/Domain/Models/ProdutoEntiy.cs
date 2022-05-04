namespace Projeto.Tests.Domain.Models
{
    public class ProdutoEntiy
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public ProdutoEntiy()
        {
        }
        public ProdutoEntiy(int id, string nome, string descricao, decimal preco)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }
    }
    public interface IVerificadorPrecoProduto
    {
        string VerificaPrecoProduto(ProdutoEntiy produtoEntiy);
    }
}
