using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            var Resultado = CalculadoraEstatica.Multiplicar(2,2);
            Console.WriteLine("O resultado é {0}.", Resultado);

            Console.WriteLine(CalculadoraEstatica.Somar(2,2));

        }
    }
}
