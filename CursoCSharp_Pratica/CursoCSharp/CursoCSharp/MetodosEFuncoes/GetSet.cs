using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class GetSet
    {
        public class Moto
        {
            private string Marca;
            private string Modelo;
            private int Cilindradas;

            public Moto()
            {
            }

            public Moto(string marca, string modelo, int cilindradas)
            {
                Marca = marca;
                Modelo = modelo;
                Cilindradas = cilindradas;
            }

            public string GetMarca()
            {
                return Marca;
            }
            public void SetMarca(string marca)
            {
                Marca = marca;
            }

            public string GetModelo()
            {
                return Modelo;
            }
            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }

            public int GetCilindradas()
            {
                return Cilindradas;
            }                      
            
            public void SetCilindradas(int cilindradas)
            {
                Cilindradas = cilindradas;
            }
        }
        public static void Executar()
        {
            Moto moto1 = new Moto(marca:"Yamaha", modelo:"MT-03", cilindradas:250);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindradas());
        }
    }
}
