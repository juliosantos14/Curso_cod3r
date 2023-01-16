using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {

    }
    internal class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("O nosso");
                    sw.WriteLine("Primeiro");
                    sw.WriteLine("Arquivo");
                }
            }  
        }
    }
}
