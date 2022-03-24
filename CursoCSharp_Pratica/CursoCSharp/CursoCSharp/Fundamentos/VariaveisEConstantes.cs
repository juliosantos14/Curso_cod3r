using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine("A area é igual a = " + area);

            sbyte MinSByte = sbyte.MinValue;
            sbyte MaxSByte = sbyte.MaxValue;

            byte MaxByte = byte.MaxValue;
            byte MinByte = byte.MinValue;

            short MinShort = short.MinValue;
            short MaxShort = short.MaxValue;

            int MaxInt = int.MaxValue;
            int MinInt = int.MinValue;

            long MaxLong = long.MaxValue;
            long MinLong = long.MinValue;

            Console.WriteLine("\nMinimo Sbyte: " + MinSByte + ", Máximo: " + MaxSByte);            

            Console.WriteLine("\nMinímo Byte: " + MinByte + ", Máximo: " + MaxByte);            

            Console.WriteLine($"\nMinímo Short: {MinShort}, Máximo: {MaxShort}");

            Console.WriteLine($"\nMinímo Int: {MinInt}, Máximo: {MaxInt}");

            Console.WriteLine($"\nMinímo Long: {MinLong}, Máximo: {MaxLong}");

            float precoComputador = 1299.99f;
            
            

        }
    }
}
