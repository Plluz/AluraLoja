namespace Alura.Loja.Testes.ConsoleApp
{
    public class ProdutoPromocao
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int PromocaoId { get; set; }
        public Promocao Promocao { get; set; }
    }
}