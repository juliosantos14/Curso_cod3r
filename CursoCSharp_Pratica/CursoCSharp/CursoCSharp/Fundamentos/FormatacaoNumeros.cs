using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class FormatacaoNumeros
    {
        public static void Executar()
        {
            double valor = 15.85;

            Console.WriteLine(valor.ToString("C")); //Currency - Transforma em Real (R$)
            Console.WriteLine(valor.ToString("F1")); // Uma casa decimal
            Console.WriteLine(valor.ToString("P"));// Multiplica por 100 e trás em porcentagem
        }
    }
}
