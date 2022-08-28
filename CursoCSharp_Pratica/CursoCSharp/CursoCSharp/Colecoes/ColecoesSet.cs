using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.Colecoes.ColecoesList;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesSet
    {      
        public static void Executar()
        {
            var Livro = new Produto("Game of Thrones", 149.99);

            var Carrinho = new HashSet<Produto>();
            Carrinho.Add(Livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("Temporada Lucifer", 99.9),
                new Produto("Poster", 10)
            };

            Carrinho.UnionWith(combo);

            Console.WriteLine(Carrinho.Count);
            //Carrinho.RemoveAt(3);

            foreach (var item in Carrinho)
            {
                //Console.Write(Carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            
            Console.WriteLine(Carrinho.Count());
            Carrinho.Add(Livro);
            Console.WriteLine(Carrinho.Count());

            //Console.WriteLine(Carrinho.LastIndexOf(Livro));
        }
    }
}
