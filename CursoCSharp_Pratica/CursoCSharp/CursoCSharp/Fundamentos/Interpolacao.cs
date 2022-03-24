using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string Nome = "Notebook Gamer";
            string Marca = "Dell";
            double Preco = 1999.00;

            Console.WriteLine("O nome do Produto é " + Nome + ". E a marca é: " + Marca + ". e o preço é: " + Preco);

            Console.WriteLine("O nome do produto é {0}. E a marca é: {1}. E o preço é: {2}", Nome, Marca, Preco);

            Console.WriteLine($"O nome do produto é {Nome}. E a marca é: {Marca}. E o preço é: {Preco}");
        }
    }
}
