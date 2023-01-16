using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public class Dependente
    {
        public string Nome;
        public int Idade;

        public override string ToString()
        {
            return $"{Nome} {Idade}";
        }
    }
    internal class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");
            
            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente()
            {
                Nome = "João",
                Idade = 15
            };

            Dependente copiaDep = dep;

            Console.WriteLine(dep);
            Console.WriteLine(copiaDep);

            dep.Nome = "Vinicius";

            Console.WriteLine(dep);
            Console.WriteLine(copiaDep);
        }
    }
}
