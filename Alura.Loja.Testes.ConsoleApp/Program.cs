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

            var compra = new Compra();
            compra.Quantidade = 4;
            compra.Produto = chocolate;
            compra.Preco = compra.Quantidade * compra.Produto.PrecoUnitario;

            var promocaoPascoa = new Promocao()
            {
                Descricao = "Páscoa Daora",
                DataInicio = DateTime.Now,
                DataTermino = DateTime.Now.AddDays(15)
            };
            promocaoPascoa.AdicionarProduto(chocolate);
            promocaoPascoa.AdicionarProduto(suco);
            promocaoPascoa.AdicionarProduto(miojo);

            var cliente = new Cliente()
            {
                Nome = "Fulano da Silva",
                EnderecoDeEntrega = new Endereco()
                {
                    Cidade = "Porto Alegre",
                    Bairro = "Passo d'Areia",
                    Rua = "Novo Hamburgo",
                    Numero = "104"
                }
            };

            //using (var contexto = new LojaContext())
            //{
            //    contexto.Clientes.Add(cliente);
            //    contexto.SaveChanges();
            //}

            Console.ReadLine();
        }
    }
}
