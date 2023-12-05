using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numero = "oo";
            while (numero != "X")
            {
                Console.WriteLine("1 - Calcular o estoque médio de uma peça.");
                Console.WriteLine("2 - Conversão de dólar para real.");
                Console.WriteLine("3 - Pagamento de comissão de vendedores de peças.");
                Console.WriteLine("4 - Operações com quatro valores numéricos inteiros.");
                Console.WriteLine("5 - Cálculo da quantidade de litros de combustível em uma viagem.");
                Console.WriteLine("6 - Conversão de temperatura de Celsius para Fahrenheit.");
                Console.WriteLine("7 - Conversão de temperatura de Fahrenheit para Celsius.");
                Console.WriteLine("8 - Cálculo do volume de uma lata de óleo.");
                Console.WriteLine("9 - Cálculo da idade em dias.");
                Console.WriteLine("10 - Relacionamentos de ordem entre dois números inteiros.");
                Console.WriteLine("11 - Troca de valores entre duas variáveis.");
                Console.WriteLine("12 - Exibição do módulo de um número.");
                Console.WriteLine("13 - Ordenação decrescente de três números inteiros.");
                Console.WriteLine("14 - Diferença entre o maior e o menor número.");
                Console.WriteLine("15 - Verificação de aprovação de um aluno com recuperação.");
                Console.WriteLine("16 - Identificação do maior e menor número.");
                Console.WriteLine("17 - Verificação se um número está na faixa de 0 a 9.");
                Console.WriteLine("18 - Identificação de código por extenso.");
                Console.WriteLine("19 - Classificação de triângulos.");
                Console.WriteLine("20 - Cálculo com três valores inteiros diferentes.");
                Console.WriteLine("21 - Verificação de número positivo ou negativo.");
                Console.WriteLine("22 - Armazenamento de número positivo em A e negativo em B.");
                Console.WriteLine("23 - Realização de operações matemáticas.");
                Console.WriteLine("24 - Verificação de propriedades entre dois números.");
                Console.WriteLine("25 - Cálculo do peso ideal baseado em altura e sexo.");
                Console.WriteLine("26 - Exibição de números de 1 a 100 em ordem decrescente.");
                Console.WriteLine("27 - Cálculo do fatorial de uma sequência de números.");
                Console.WriteLine("28 - Exibição de números ímpares entre 100 e 200.");
                Console.WriteLine("29 - Exibição de números de 1 a 200.");
                Console.WriteLine("30 - Impressão de uma tabuada.");
                Console.WriteLine("31 - Verificação de números pares ou ímpares em um conjunto.");
                Console.WriteLine("32 - Cálculo da média da nota dos alunos de uma turma.");
                Console.WriteLine("33 - Identificação do maior e menor número em um conjunto.");
                Console.WriteLine("34 - Contagem de múltiplos de 10 até 100.");
                Console.WriteLine("35 - Leitura de 10 valores e identificação de maior, menor e média.");
                Console.WriteLine("36 - Menu de conversão de base numérica.");
                Console.WriteLine("37 - Cálculo de salário com horas trabalhadas e horas extras.");
                Console.WriteLine("38 - Verificação de número par, ímpar, positivo ou negativo.");
                Console.WriteLine("39 - Notificação de indústrias baseada no índice de poluição.");
                Console.WriteLine("40 - Classificação de nadadores por idade.");
                Console.WriteLine("41 - Identificação do maior e menor entre N números.");
                Console.WriteLine("42 - Cálculo do número de grãos em um tabuleiro de xadrez.");
                Console.WriteLine("43 - Menu de opções: conversão de temperatura, peso ideal.");
                Console.WriteLine("44 - Sorteio de um número de 0 a 100 com tentativas do usuário.");
                Console.WriteLine("45 - Impressão de uma sequência de números na ordem inversa.");
                Console.WriteLine("46 - Cálculo do produto escalar de dois vetores.");
                Console.WriteLine("47 - Verificação de números maiores, menores e iguais a X em um vetor.");
                Console.WriteLine("48 - Identificação de candidatas aptas para uma campanha publicitária.");
                Console.WriteLine("49 - Cálculo do desconto de um produto.");
                Console.WriteLine("50 - Simulação de caixa eletrônico: saque, depósito e consulta de saldo.");
                Console.WriteLine("51 - Leitura de notas de alunos e cálculo de média e aprovação.");
                Console.WriteLine("52 - Contagem de ocorrências específicas em um vetor.");
                Console.WriteLine("53 - Análise de tempos de voltas em uma corrida de automóveis.");
                Console.WriteLine("54 - Impressão de elementos comuns entre dois vetores.");
                Console.WriteLine("55 - Remoção de espaços em branco de uma frase.");
                Console.WriteLine("56 - Cálculo da média e maior número em um vetor de inteiros.");
                Console.WriteLine("57 - Impressão de vogais em uma frase.");
                Console.WriteLine("58 - Leitura e impressão de números pares e múltiplos de 5 em um vetor.");
                Console.WriteLine("59 - Contagem de caracteres entre dois informados em ordem alfabética.");
                Console.WriteLine("60 - Verificação do quadrante a partir de coordenadas x e y.");
                Console.WriteLine("61 - Cálculo de salário atualizado com base em reajuste.");
                Console.WriteLine("62 - Cálculo da hipotenusa de um triângulo.");
                Console.WriteLine("63 - Verificação se um número é par ou ímpar.");
                Console.WriteLine("64 - Menu de opções para manipulação de um vetor.");
                Console.WriteLine("X - Para encerrar o programa");
                Console.WriteLine("");

                Console.Write("Digite o número desejado :");

                numero = Console.ReadLine().ToUpper();

                Console.Clear();

                switch (numero)
                {
                    case "1":
                        Atividade01.Executar();
                        break;
                    case "2":
                        Atividade02.Executar();
                        break;
                    case "3":
                        Atividade03.Executar();
                        break;
                    case "4":
                        Atividade04.Executar();
                        break;
                    case "5":
                        Atividade05.Executar();
                        break;
                    case "6":
                        Atividade06.Executar();
                        break;
                    case "7":
                        Atividade07.Executar();
                        break;
                    case "8":
                        Atividade08.Executar();
                        break;
                    case "9":
                        Atividade09.Executar();
                        break;
                    case "10":
                        Atividade10.Executar();
                        break;
                    case "11":
                        Atividade11.Executar();
                        break;
                    case "12":
                        Atividade12.Executar();
                        break;
                    case "13":
                        Atividade13.Executar();
                        break;
                    case "14":
                        Atividade14.Executar();
                        break;
                    case "15":
                        Atividade15.Executar();
                        break;
                    case "16":
                        Atividade16.Executar();
                        break;
                    case "17":
                        Atividade17.Executar();
                        break;
                    case "18":
                        Atividade18.Executar();
                        break;
                    case "19":
                        Atividade19.Executar();
                        break;
                    case "20":
                        Atividade20.Executar();
                        break;
                    case "21":
                        Atividade21.Executar();
                        break;
                    case "22":
                        Atividade22.Executar();
                        break;
                    case "23":
                        Atividade23.Executar();
                        break;
                    case "24":
                        Atividade24.Executar();
                        break;
                    case "25":
                        Atividade25.Executar();
                        break;
                    case "26":
                        Atividade26.Executar();
                        break;
                    case "27":
                        Atividade27.Executar();
                        break;
                    case "28":
                        Atividade28.Executar();
                        break;
                    case "29":
                        Atividade29.Executar();
                        break;
                    case "30":
                        Atividade30.Executar();
                        break;
                    case "31":
                        Atividade31.Executar();
                        break;
                    case "32":
                        Atividade32.Executar();
                        break;
                    case "33":
                        Atividade33.Executar();
                        break;
                    case "34":
                        Atividade34.Executar();
                        break;
                    case "35":
                        Atividade35.Executar();
                        break;
                    case "36":
                        Atividade36.Executar();
                        break;
                    case "37":
                        Atividade37.Executar();
                        break;
                    case "38":
                        Atividade38.Executar();
                        break;
                    case "39":
                        Atividade39.Executar();
                        break;
                    case "40":
                        Atividade40.Executar();
                        break;
                    case "41":
                        Atividade41.Executar();
                        break;
                    case "42":
                        Atividade42.Executar();
                        break;
                    case "43":
                        Atividade43.Executar();
                        break;
                    case "44":
                        Atividade44.Executar();
                        break;
                    case "45":
                        Atividade45.Executar();
                        break;
                    case "46":
                        Atividade46.Executar();
                        break;
                    case "47":
                        Atividade47.Executar();
                        break;
                    case "48":
                        Atividade48.Executar();
                        break;
                    case "49":
                        Atividade49.Executar();
                        break;
                    case "50":
                        Atividade50.Executar();
                        break;
                    case "51":
                        Atividade51.Executar();
                        break;
                    case "52":
                        Atividade52.Executar();
                        break;
                    case "53":
                        Atividade53.Executar();
                        break;
                    case "54":
                        Atividade54.Executar();
                        break;
                    case "55":
                        Atividade55.Executar();
                        break;
                    case "56":
                        Atividade56.Executar();
                        break;
                    case "57":
                        Atividade57.Executar();
                        break;
                    case "58":
                        Atividade58.Executar();
                        break;
                    case "59":
                        Atividade59.Executar();
                        break;
                    case "60":
                        Atividade60.Executar();
                        break;
                    case "61":
                        Atividade61.Executar();
                        break;
                    case "62":
                        Atividade62.Executar();
                        break;
                    case "63":
                        Atividade63.Executar();
                        break;
                    case "64":
                        Atividade64.Executar();
                        break;
                    case "X":
                        Console.WriteLine("Fechando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Console.ReadKey();

                        Console.Clear();

                        break; 


                }
            }
        }
    }
}