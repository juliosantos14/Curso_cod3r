using System;
using System.Collections.Generic;
using System.Linq;
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
                new Aluno(){Nome = "Julia", Idade = 24, Nota=3.7},
                new Aluno(){Nome = "Ana", Idade = 24, Nota=2.1},
            };

            var pedro = alunos.Single(a => a.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome}, {pedro.Nota}");
        }
    }
}
