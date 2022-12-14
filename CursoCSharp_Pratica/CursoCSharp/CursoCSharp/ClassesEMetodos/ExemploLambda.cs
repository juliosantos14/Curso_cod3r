using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C# ");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            // Igual a Func acima porém mais extensa
            Func<int, string> conversorHexa = (numero) =>
            {
               return numero.ToString("X");
            };

            Func<int, int, int, string> formatarData = (dia, mes, ano) => 
            String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            Console.WriteLine(formatarData(01,01,2020));

            }
    }
}
