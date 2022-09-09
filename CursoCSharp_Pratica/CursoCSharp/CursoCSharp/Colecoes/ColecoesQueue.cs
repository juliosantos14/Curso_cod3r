using System;
using System.Collections.Generic;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>(); //Precisa utilizar o "using System.Collections.Generic;"
            fila.Enqueue("Adriana"); //Enqueue adiciona um item na lista/coleção;
            fila.Enqueue("Anderson");
            fila.Enqueue("Abilene");
            fila.Enqueue("Clayton");

            Console.WriteLine(fila.Peek()); //Retorna o primeiro item da Lista/coleção;
            Console.WriteLine(fila.Count); //Retorna a quantidade de itens da lista/coleção;
            Console.WriteLine(fila.Dequeue()); //Elimina o primeiro item da lista/coleção;
            Console.WriteLine(fila.Count);
            Console.WriteLine();

            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var salada = new Queue(); //Precisa utilizar o "using System.Collections;"

            salada.Enqueue(3);
            salada.Enqueue("Julio");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Julio")); //Contains = Checa se aquele item existe dentro da coleção;
            Console.WriteLine(salada.Contains("Abobrinha"));

        }
    }
}
