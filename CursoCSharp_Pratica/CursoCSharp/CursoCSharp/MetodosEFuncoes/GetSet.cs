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
        }
        public static void Executar()
        {
            Moto moto1 = new Moto();
            moto1.SetMarca("Yamaha");
            Console.WriteLine(moto1.GetMarca());
            
        }
    }
}
