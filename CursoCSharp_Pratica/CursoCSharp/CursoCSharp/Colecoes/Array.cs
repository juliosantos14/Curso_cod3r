using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] Alunos = new string[5];
            Alunos[0] = "Anderson";
            Alunos[1] = "Bianca";
            Alunos[2] = "Gabriela";
            Alunos[3] = "Iara";
            Alunos[4] = "Davi";

            foreach (var aluno in Alunos)
            {
                Console.WriteLine(aluno);
            }

            double Somatorio = 0; ;
            double[] Notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var Nota in Notas)
            {
                Somatorio += Nota;
            }

            for (int i = 0; i < Notas.Length; i++)
            {
                Somatorio += Notas[i];
            }
            double Media = Somatorio / Notas.Length;
            Console.WriteLine("Media: {0}", Media);

            char[] Letras = { 'A', 'B', 'C', 'D' };
            string Palavra = new string(Letras);
            Console.WriteLine(Palavra); 
        }
    }
}
