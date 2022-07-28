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
            private uint Cilindradas;

            public Moto()
            {
            }

            public Moto(string marca, string modelo, uint cilindradas)
            {
                //Marca = marca;
                //Modelo = modelo;
                //Cilindradas = cilindradas;
                SetMarca(marca);
                SetModelo(modelo);
                SetCilindradas(cilindradas);
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

            public uint GetCilindradas()
            {
                return Cilindradas;
            }                      
            
            public void SetCilindradas(uint cilindradas)
            {
                //Primeira Opção
                //if (cilindradas > 0)
                //{
                //    Cilindradas = cilindradas;
                //}

                //Segunda Opção
                //Cilindradas = Math.Abs(cilindradas);   

                Cilindradas = cilindradas;                
            }
        }
        public static void Executar()
        {
            Moto moto1 = new Moto(marca:"Yamaha", modelo:"MT-03", cilindradas:635);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindradas());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CB300");
            moto2.SetCilindradas(300);

            Console.WriteLine("Marca: " + moto2.GetMarca() + "\nModelo: " + moto2.GetModelo() + "\nCilindradas: " + moto2.GetCilindradas());
        }
    }
}
