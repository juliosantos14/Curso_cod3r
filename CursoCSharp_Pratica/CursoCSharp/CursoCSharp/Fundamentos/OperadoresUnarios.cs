using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var boolean = true;

            Console.WriteLine(+valorNegativo);
            Console.WriteLine(-valorNegativo);
            Console.WriteLine(valorNegativo);

            Console.WriteLine(!boolean);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);
            numero1--;
            Console.WriteLine(numero1);

            numero1++;
            Console.WriteLine(numero1);

            Console.WriteLine(++numero1 == --numero2);//Valor false
            Console.WriteLine(numero1++ == --numero2);//Valor verdadeiro pois altera o valor de numero 2 antes por estar com -- antes da variavel
            Console.WriteLine($"{numero1} {numero2}");

        }
    }
}
