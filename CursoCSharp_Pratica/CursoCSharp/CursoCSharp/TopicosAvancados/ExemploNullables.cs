using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class ExemploNullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num: " + num1);
            }
            else
            {
                Console.WriteLine("A variavel não possui valor");
            }

            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();

            try
            {
                int x = num1.Value;
                int y = num2.Value;
                Console.WriteLine(x + y);
            }catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
    }
}
