using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande truque");


            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004 - " + filmes[2004]);//Se não tiver nenhum dado na chave passada ocorrerá um erro
                Console.WriteLine("2004 - " + filmes.GetValueOrDefault(2004));//Se não tiver nenhum valor na chave passada será retornado vazio
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));
            Console.WriteLine(filmes.ContainsValue("Os Incriveis"));

            Console.WriteLine("Removeu? {0}", filmes.Remove(2004));// Remove o valor conforme chave selecionada e retorna Verdadeiro ou Falso
            Console.WriteLine();


            //Percorrer entre as chaves
            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            Console.WriteLine();

            foreach (var valor in filmes.Keys)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine();

            foreach (KeyValuePair<int, string>filme in filmes)
            {
                Console.WriteLine("{0} é de {1}", filme.Value, filme.Key);
            }
        }
    }
}
