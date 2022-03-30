using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatacaoNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;

            Console.WriteLine(valor.ToString("C")); //Currency - Transforma em Real (R$)
            Console.WriteLine(valor.ToString("F1")); // Uma casa decimal
            Console.WriteLine(valor.ToString("P"));// Multiplica por 100 e trás em porcentagem

            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
