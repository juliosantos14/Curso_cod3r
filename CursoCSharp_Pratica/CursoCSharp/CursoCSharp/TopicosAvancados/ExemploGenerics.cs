using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T>
    {
        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa (T coisa)
        {
            Coisa = coisa;
        }

        public T metodoGenerico(T valor)
        {

        }
    }
    internal class ExemploGenerics
    {
        public static void Executar()
        {

        }
    }
}
