namespace Alura.Loja.Testes.ConsoleApp
{
    public class Produto
    {
        public Produto()
        {

        }
        public Produto(string categoria, string nome, double preco)
        {
            Categoria = categoria;
            Nome = nome;
            PrecoUnitario = preco;
        }
        public int Id { get; internal set; }
        public string Categoria { get; internal set; }
        public string Nome { get; internal set; }
        public double PrecoUnitario { get; internal set; }
        public string Unidade { get; set; }

        public override string ToString()
        {
            return $"[{this.Id}] {this.Categoria} - {this.Nome} - {this.PrecoUnitario}";
        }
    }
}