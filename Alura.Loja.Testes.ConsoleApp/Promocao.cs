using System;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Promocao
    {
        public Promocao()
        {
            this.Produtos = new List<ProdutoPromocao>();
        }

        public int Id { get; set; }
        public string Descricao { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataTermino { get; internal set; }
        public IList<ProdutoPromocao> Produtos { get; internal set; }

        internal void AdicionarProduto(Produto p)
        {
            this.Produtos.Add(new ProdutoPromocao() { Produto = p });
        }
    }
}