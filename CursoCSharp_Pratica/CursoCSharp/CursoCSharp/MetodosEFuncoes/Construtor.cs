using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{

    public class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;
        public Carro()
        {

        }
        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }     

        public override string ToString()
        {
            return $"{Modelo} {Fabricante} {Ano}";
        }
    }
    internal class Construtor
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Modelo = "BMW";
            carro1.Fabricante = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 1994
            };

            Console.WriteLine(carro3);
        }
    }
}
