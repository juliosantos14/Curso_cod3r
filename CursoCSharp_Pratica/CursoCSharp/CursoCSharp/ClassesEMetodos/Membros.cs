using System;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa sincrano = new Pessoa();
            sincrano.Nome = "Renato";
            sincrano.Idade = 27;

            //Console.WriteLine($"{sincrano.Nome} tem {sincrano.Idade} anos.");

            sincrano.ApresentarNoConsole();
            sincrano.Zerar();
            sincrano.ApresentarNoConsole();


            var fulano = new Pessoa();
            fulano.Nome = "Jorge";
            fulano.Idade = 21;

            var apresentarFulano = fulano.Apresentar();
            Console.WriteLine(apresentarFulano);
            Console.WriteLine(apresentarFulano.Length);            

        }
    }
}
