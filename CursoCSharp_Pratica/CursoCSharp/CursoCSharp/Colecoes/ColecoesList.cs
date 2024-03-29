﻿using System;
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
            public override bool Equals(object obj)
            {
                Produto outroProduto = (Produto)obj;
                bool mesmoNome = Nome == outroProduto.Nome;
                bool mesmoPreco = Preco == outroProduto.Preco;

                return mesmoNome && mesmoPreco;
            }
        }
        public static void Executar()
        {
            var Livro = new Produto("Game of Thrones", 149.99);
            var Carrinho = new List<Produto>();
            Carrinho.Add(Livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("Temporada Lucifer", 99.9),
                new Produto("Poster", 10)
            };

            Carrinho.AddRange(combo);
            Console.WriteLine(Carrinho.Count);
            Carrinho.RemoveAt(3);

            foreach (var item in Carrinho)
            {
                Console.Write(Carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            
            Console.WriteLine(Carrinho.Count());
            Carrinho.Add(Livro);
            Console.WriteLine(Carrinho.Count());

            Console.WriteLine(Carrinho.LastIndexOf(Livro));
        }
    }
}
