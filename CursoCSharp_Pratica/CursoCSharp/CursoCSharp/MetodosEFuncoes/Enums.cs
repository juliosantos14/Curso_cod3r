using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroFilme;
    }
    internal class Enums
    {        
        public static void Executar()
        {
            //int id = (int)Genero.Animacao;
            //Console.WriteLine(id);

            Filme filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "007";
            filmeParaFamilia.GeneroFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroFilme);
        }
    }
}
