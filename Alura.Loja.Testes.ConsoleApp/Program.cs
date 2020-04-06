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
            using (var contexto = new LojaContext())
            {
                var produtos = contexto.Produtos.ToList();
                foreach (var p in produtos)
                {
                    Console.WriteLine(p);
                }

                var p1 = produtos.First();
                p1.Nome = "testeeeeeeeee";
                contexto.SaveChanges();

                produtos = contexto.Produtos.ToList();
                foreach (var p in produtos)
                {
                    Console.WriteLine(p);
                }
            }

            //GravarProduto();
            //RecuperarProdutos();
            //AtualizarProduto();
            //RecuperarProdutos();
            //ExcluirProdutos();
            //RecuperarProdutos();

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

        private static void GravarProduto()
        {
            Console.WriteLine("Gravando dados...");
            Produto p = new Produto("Livros", "Harry Potter e a Ordem da Fênix", 19.90);

            using (var contexto = new ProdutoDAO())
            {
                contexto.Adicionar(p);
            }
        }
    }
}
