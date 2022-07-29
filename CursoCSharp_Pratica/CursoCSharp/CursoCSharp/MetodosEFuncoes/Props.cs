using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class Props
    {
        public class CarroOpcional
        {
            double Desconto = 0.1;

            string nome;
            public string Nome
            {
                get { return "Opcional: " + nome; }
                set { nome = value; }
            }

            //Propriedades autoimplementada
            public double Preco { get; set; }
            
            //Somente leitura
            public double PrecoComDesconto
            {
                get => Preco - (Preco * Desconto); //Lamda

                //get
                //{
                //    return Preco - (Preco * desconto);
                //}
            }

            public CarroOpcional()
            {
            }

            public CarroOpcional(string nome, double preco)
            {                              
                Nome = nome;
                Preco = preco;
            }

        }

        public static void Executar()
        {
            CarroOpcional op1 = new CarroOpcional(nome: "Ar Condicionado", preco: 3499.99);            

            CarroOpcional op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            Console.WriteLine(op1.PrecoComDesconto.ToString("f2"));

            Console.WriteLine("\n" + op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto.ToString("f2"));


        }
    }
}
