using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.Colecoes.ColecoesList;

namespace CursoCSharp.Colecoes
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p1;

            Console.WriteLine(p1 == p2); //Aponta para locais diferentes da memória
            Console.WriteLine(p3 == p1); //Aponta para o mesmo local na memória

            Console.WriteLine(p1.Equals(p2));
        }
    }
}
