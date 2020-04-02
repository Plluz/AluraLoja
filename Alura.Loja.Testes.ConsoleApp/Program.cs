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
            //GravarUsandoAdoNet();
            GravarProduto();
            RecuperarProdutos();
            AtualizarProduto();
            RecuperarProdutos();
            ExcluirProdutos();
            RecuperarProdutos();

            Console.ReadLine();
        }

        private static void AtualizarProduto()
        {
            Console.WriteLine("Atualizando dados...");
            using (var db = new LojaContext())
            {
                var produto = db.Produtos.FirstOrDefault();
                produto.Preco = 14.90;
                db.Produtos.Update(produto);
                db.SaveChanges();
            }
        }

        private static void ExcluirProdutos()
        {
            Console.WriteLine("Excluindo dados...");
            using (var db = new LojaContext())
            {
                IList<Produto> produtos = db.Produtos.ToList();
                foreach (var item in produtos)
                {
                    db.Produtos.Remove(item);
                }
                db.SaveChanges();
            }
        }

        private static void RecuperarProdutos()
        {
            Console.WriteLine("Obtendo dados...");
            using (var loja = new LojaContext())
            {
                IList<Produto> produtos = loja.Produtos.ToList();
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome + " - " + item.Preco);
                }
            }
        }

        private static void GravarProduto()
        {
            Console.WriteLine("Gravando dados...");
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var contexto = new LojaContext())
            {
                contexto.Produtos.Add(p);
                contexto.SaveChanges();
            }
        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}
