using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class ReadOnly
    {
        public class Cliente
        {
            public string Nome;
            readonly DateTime Nascimento;
            public Cliente(string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }

            public string GetDataNascimento()
            {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }
        }
        public static void Executar()
        {
            Cliente novoCliente = new Cliente("Ana Carolina", new DateTime(day: 22, month: 5, year: 1987));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());
        }
    }
}
