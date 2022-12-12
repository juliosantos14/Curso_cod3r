using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }

    class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }
    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }
    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>()
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }

            return resultado;
        }
    }
    internal class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            Console.WriteLine("Digite o primeiro numero");
            var v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo numero");            
            var v2 = int.Parse(Console.ReadLine());
            //var resultado = calc.ExecutarOperacoes(20, 5);
            var resultado = calc.ExecutarOperacoes(v1, v2);
            Console.WriteLine(resultado);
        }
    }
}
