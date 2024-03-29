﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    public class LINQ1
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

            Console.WriteLine("== Aprovados =============");
            var aprovados = alunos.Where(a => a.Nota >= 5).OrderBy(a => a.Nome);
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n== Chamada ===========");
            var chamada = alunos.OrderBy(a => a.Nome);
            var chamadaNome = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamadaNome)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n== Aprovados por Idade");
            var aprovadorPorIdade = alunos.Where(a => a.Nota > 7).OrderBy(a => a.Nota);
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach (var aluno in aprovadorPorIdade)
            {
                Console.WriteLine(aluno.Nome + ", Nota = " + aluno.Nota);
            }
            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
