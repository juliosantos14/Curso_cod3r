using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class ExemploDynamic
    {
        public static void Executar()
        {
            dynamic meuObjeto = "Teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);
        }
    }
}
