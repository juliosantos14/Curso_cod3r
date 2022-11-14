using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Animal {

        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    internal class ConstrutorThis
    {
        public static void Executar()
        {

        }
    }
}
