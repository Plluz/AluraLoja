using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarProduto();
            //RecuperarProdutos();
            //AtualizarProduto();
            //RecuperarProdutos();
            //ExcluirProdutos();
            //RecuperarProdutos();


            //var chocolate = new Produto()
            //{
            //    Nome = "CHOCOLATE HERSHEY'S 90G",
            //    Categoria = "ALIMENTO",
            //    PrecoUnitario = 4.38,
            //    Unidade = "UNIDADE"
            //};

            //var compra = new Compra();
            //compra.Quantidade = 4;
            //compra.Produto = chocolate;
            //compra.Preco = compra.Quantidade * compra.Produto.PrecoUnitario;

            var promocaoPascoa = new Promocao();
            promocaoPascoa.Descricao = "Páscoa Daora";
            promocaoPascoa.DataInicio = DateTime.Now;
            promocaoPascoa.DataTermino = DateTime.Now.AddDays(15);
            //promocaoPascoa.Produtos.Add(new Produto());

            Console.ReadLine();
        }

        private static void AtualizarProduto()
        {
            Console.WriteLine("Atualizando dados...");
            using (var db = new ProdutoDAO())
            {
                var produto = db.Produtos().FirstOrDefault();
                produto.PrecoUnitario = 14.90;
                db.Atualizar(produto);
            }
        }

        private static void ExcluirProdutos()
        {
            Console.WriteLine("Excluindo dados...");
            using (var db = new ProdutoDAO())
            {
                IList<Produto> produtos = db.Produtos();
                foreach (var item in produtos)
                {
                    db.Remover(item);
                }
            }
        }

        private static void RecuperarProdutos()
        {
            Console.WriteLine("Obtendo dados...");
            using (var loja = new ProdutoDAO())
            {
                IList<Produto> produtos = loja.Produtos();
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome + " - " + item.PrecoUnitario);
                }
            }
        }

        private static void GravarProdutos(List<Produto> produtos)
        {
            Console.WriteLine("Gravando dados...");

            using (var contexto = new ProdutoDAO())
            {
                foreach (var p in produtos)
                {
                    contexto.Adicionar(p);
                }
            }
        }
    }
}
