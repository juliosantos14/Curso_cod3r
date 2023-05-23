using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class LINQ2
    {
        public static void Executar()
        {

            var alunos = new List<Aluno>
            {
                    new Aluno(){Nome = "Pedro", Idade = 24, Nota=8.0},
                    new Aluno(){Nome = "Andre", Idade = 21, Nota=4.3},
                    new Aluno(){Nome = "Alessandro", Idade = 24, Nota=7.5},
                    new Aluno(){Nome = "Wellington", Idade = 25, Nota=9.2},
                    new Aluno(){Nome = "Davi", Idade = 24, Nota=8.4},
                    new Aluno(){Nome = "Julia", Idade = 28, Nota=3.7},
                    new Aluno(){Nome = "Ana", Idade = 24, Nota=2.1},
                };

            //Se Pedro não existir então será retornado um erro
            var pedro = alunos.Single(a => a.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome}, {pedro.Nota}");

            //Se fulano nao existir será retornado NULL
            var fulano = alunos.SingleOrDefault(a => a.Nome.Equals("Fulano"));
            
            if (fulano == null)
            {
                Console.WriteLine("Aluno Inexistente");
            };

            //Se ana não existir então será retornado um erro
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            
            //Se ana2 nao existir será retornado NULL
            var ana2 = alunos.FirstOrDefault(a => a.Nome.Equals("Ana2"));
            if (ana2 == null)
            {
                Console.WriteLine("Aluno inexistente");
            }

            //Caso tenha duas pessoas ou mais com o mesmo nome ele pegará os dados do ultimo
            var TestMetodoLastOrDefault = alunos.LastOrDefault(a => a.Nome.Equals("Davi"));
            Console.WriteLine(TestMetodoLastOrDefault.Nota);

            var exemploSkip = alunos.Skip(1).Take(4);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(a => a.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(a => a.Nota);
            Console.WriteLine(menorNota);

            var somarNotas = alunos.Sum(a => a.Nota);
            Console.WriteLine(somarNotas);

            var mediaNotas = alunos.Average(a => a.Nota);
            Console.WriteLine(mediaNotas);

            var alunosAprovador = alunos.Where(a => a.Nota >= 7).Average(a => a.Nota);
            Console.WriteLine(alunosAprovador);
        }


        
}
}
