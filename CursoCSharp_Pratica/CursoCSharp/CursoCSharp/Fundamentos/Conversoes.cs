using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;

            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;

            Console.WriteLine("Nota truncada: {0} ", notaTruncada);

            Console.Write("\nDigite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inteiro {0}",idadeInteiro);
            
            Console.Write("\nDigite sua idade: ");
            string idadeString2 = "14";
            int idadeInteiro2 = int.Parse(idadeString2);
            Console.WriteLine("Idade inteiro {0}",idadeInteiro2);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("\nDigite um número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado utilizando TryParse: {0}", numero);

            Console.Write("\nDigite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("\nResultado utilizando TryParse: {0}", numero2);
            
        }
    }
}
