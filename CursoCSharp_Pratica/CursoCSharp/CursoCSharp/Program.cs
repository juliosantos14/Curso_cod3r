using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", FirstProgram.Executar } ,
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia .Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatação de Números - Fundamentos", FormatacaoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},                  
                
                //Estruturas de controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar},
                 
                //Classes e Metodos (Pasta MetodosEFuncoes)
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtor - Classes e Métodos", Construtor.Executar},
                {"Metodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Getters e Setters - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"ReadOnly - Classes e Métodos", ReadOnly.Executar},
                {"Enum - Classes e Métodos", Enums.Executar},
                {"Struct - Classes e Métodos", Struct.Executar},
                {"Struct Vs Classe - Classes e Métodos", StrucVsClasse.Executar},
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parametro por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parametro padrão - Classes e Métodos", ParametroPadrao.Executar},                

                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar}, 

                //OO
                {"Herança - OOP", Heranca.Executar},
                {"Construtor This - OOP", ConstrutorThis.Executar},
                {"Encapsulamento - OOP", OO.Encapsulamento.Executar},
                {"Polimorfismo - OOP", OO.Polimorfismo.Executar},
                {"Classe Abstrata - OOP", Abstract.Executar},
                {"Interface - OOP", Interface.Executar},
                {"Classe e metodo Sealed - OOP", Sealed.Executar},

                //Metodos E Funções (Pasta ClassesEMetodos)
                {"Expressão Lambda - Métodos e Funções", ExemploLambda.Executar },
                {"Delegate Lambda - Métodos e Funções", LambdasDelegate.Executar },
                {"Usando Delegate - Métodos e Funções", UsandoDelegates.Executar },
                {"Delegate com FUnções Anonimas - Métodos e Funções", DelegateFuncAnonima.Executar },
                {"Delegate como parametros - Métodos e Funções", DelegatesComoParametro.Executar },
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar },


            }); central.SelecionarEExecutar();


        }
    }
}