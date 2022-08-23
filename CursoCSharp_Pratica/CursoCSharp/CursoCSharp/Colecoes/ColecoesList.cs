using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesList
    {
        public class Produto
        {
            public string Nome;
            public double Preco;
            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar()
        {
            var Livroi = new Produto("Game of Thrones", 149.99);
            var Carrinho = new List<Produto>();

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("Temporada Lucifer", 99.9),
                new Produto("Poster", 10)
            };

            Carrinho.AddRange(combo);
            Console.WriteLine(Carrinho.Count);
        }
    }
}
