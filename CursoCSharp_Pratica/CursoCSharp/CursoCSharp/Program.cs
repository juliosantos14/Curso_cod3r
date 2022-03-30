﻿using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", FirstProgram.Executar},
                {"Fundamentos - Comentários", Comentarios.Executar},
                {"Fundamentos - Variaveis e Constantes", VariaveisEConstantes.Executar},
                {"Fundamentos - Interpolação", Interpolacao.Executar},
                {"Fundamentos - Formatação de Números", FormatacaoNumeros.Executar},
                {"Fundamentos - Conversões", Conversoes.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}