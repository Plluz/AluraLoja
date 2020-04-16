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
            var chocolate = new Produto()
            {
                Nome = "CHOCOLATE HERSHEY'S 90G",
                Categoria = "ALIMENTO",
                PrecoUnitario = 4.38,
                Unidade = "UNIDADE"
            };
            var suco = new Produto()
            {
                Nome = "NATURALE 1L",
                Categoria = "BEBIDA",
                PrecoUnitario = 6.49,
                Unidade = "UNIDADE"
            };
            var miojo = new Produto()
            {
                Nome = "NISSIN MIOJO CARNE",
                Categoria = "ALIMENTO",
                PrecoUnitario = 0.99,
                Unidade = "UNIDADE"
            };

            var promocaoPascoa = new Promocao()
            {
                Descricao = "Páscoa Daora",
                DataInicio = DateTime.Now,
                DataTermino = DateTime.Now.AddDays(15)
            };
            promocaoPascoa.AdicionarProduto(chocolate);
            promocaoPascoa.AdicionarProduto(suco);
            promocaoPascoa.AdicionarProduto(miojo);

            using (var contexto = new LojaContext())
            {
                contexto.Promocoes.Add(promocaoPascoa);
                contexto.SaveChanges();
            }

            //var compra = new Compra();
            //compra.Quantidade = 4;
            //compra.Produto = chocolate;
            //compra.Preco = compra.Quantidade * compra.Produto.PrecoUnitario;

            Console.ReadLine();
        }
    }
}
