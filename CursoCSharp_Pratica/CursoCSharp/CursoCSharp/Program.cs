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
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Fundamentos - Formatação de Números", FormatacaoNumeros.Executar},
                {"Fundamentos - Conversões", Conversoes.Executar},
                {"Fundamentos - Operadores Aritméticos", OperadoresAritmeticos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}