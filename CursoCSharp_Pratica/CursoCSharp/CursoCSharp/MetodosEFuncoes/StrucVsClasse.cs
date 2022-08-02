using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class StrucVsClasse
    {
        public struct SPonto
        {
            public int X;
            public int Y;
        }
        public class CPonto
        {
            public int X;
            public int Y;
        }
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; //Atribuição por Valor
            ponto1.X = 5;

            Console.WriteLine("Ponto 1: {0}", ponto1.X);
            Console.WriteLine("Copia ponto 1: {0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 5, Y = 5 };
            CPonto copiaPonto2 = ponto2; // Atribuição por referência
            ponto2.X = 7;

            Console.WriteLine("Ponto 2: {0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2: {0}", copiaPonto2.X);
        }
    }
}
