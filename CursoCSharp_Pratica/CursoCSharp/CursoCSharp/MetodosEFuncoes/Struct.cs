using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }
    struct Coordenada : Ponto 
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }

    internal class Struct
    {
        public static void Executar()
        {
            Coordenada CoordenadaInicial;

            Console.WriteLine("Coordenada Inicial: ");
            CoordenadaInicial.X = 2;
            CoordenadaInicial.Y = 2;
            Console.WriteLine("Coordenada X: {0}", CoordenadaInicial.X);
            Console.WriteLine("Coordenada Y: {0}", CoordenadaInicial.Y);

            var CoordenadaFinal = new Coordenada(x: 2, y: 2);
            CoordenadaFinal.MoverNaDiagonal(10);
            Console.WriteLine("Coordenada Final {0}", CoordenadaFinal.X);
            Console.WriteLine("Coordenada Final: {0}", CoordenadaFinal.Y);
        }
    }
}
