using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", FirstProgram.Executar } ,
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Fundamentos - Variaveis e Constantes", VariaveisEConstantes.Executar},
                {"Fundamentos - Interpolação", Interpolacao.Executar},
                {"Fundamentos - Formatação de Números", FormatacaoNumeros.Executar},
                {"Fundamentos - Conversões", Conversoes.Executar},
                {"Fundamentos - Operadores Aritméticos", OperadoresAritmeticos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}