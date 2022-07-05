using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {

            //Calculo Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O total com desconto é R$ {0}", totalComDesconto);

            //Calculo IMC
            double peso = 77.7;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine("O seu IMC é " + imc.ToString("f4") + ".");

            //Calulo Impar e Par 
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par%2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar%2);
        }
    }
}
