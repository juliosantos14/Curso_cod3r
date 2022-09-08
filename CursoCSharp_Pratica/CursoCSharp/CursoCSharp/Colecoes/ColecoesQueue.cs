using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();
            fila.Enqueue("Adriana");
            fila.Enqueue("Anderson");
            fila.Enqueue("Abilene");
            fila.Enqueue("Clayton");

            Console.WriteLine(fila.Peek());
        }
    }
}
