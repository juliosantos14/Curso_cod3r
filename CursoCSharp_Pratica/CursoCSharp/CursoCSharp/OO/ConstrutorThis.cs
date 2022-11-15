﻿using CursoCSharp.MetodosEFuncoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

    public class Cachorro : Animal
    {
        public double Altura { get; set; }
        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} instanciado");
        }

        public Cachorro (double altura, string nome) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura.";
        }
    }

    internal class ConstrutorThis
    {
        public static void Executar()
        {

        }
    }
}
