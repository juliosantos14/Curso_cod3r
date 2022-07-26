using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class CalculadoraComum{
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int c, int d)
        {
            return c - d;
        }
        public int Multiplicar(int e, int f)
        {
            return e * f;
        }
        public int Dividir(int g, int h)
        {
            return g / h;
        }

       
    }
     class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado()
        {
            return memoria;
        }


    }
    internal class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultadoSoma = calculadoraComum.Somar(5, 10);
            Console.WriteLine($"A soma dos valores é {resultadoSoma}");

            Console.WriteLine("A subtração dos valores é " + calculadoraComum.Subtrair(20,2));
            Console.WriteLine("A multiplicação dos valores é " + calculadoraComum.Multiplicar(4, 4));
            Console.WriteLine("A divisão dos valores é igual a " + calculadoraComum.Dividir(10,2));

            
            //Calculadora Cadeia
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3)
                .Multiplicar(3)
                .Imprimir()
                .Limpar()
                .Imprimir();

            var resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
