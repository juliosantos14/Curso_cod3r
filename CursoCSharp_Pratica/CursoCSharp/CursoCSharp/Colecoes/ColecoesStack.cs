﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); // Método Pop remove o ultimo item adicionado na lista

            foreach (var item in pilha)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); //Método Peek retorna o primeiro item da lista
            Console.WriteLine(pilha.Count);
        }
    }
}
