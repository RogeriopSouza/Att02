using System;

namespace Exercicio02
{
    public class Atividade40
    {
        public static void Executar()
        {
            string resposta;

            do
            {
                Console.WriteLine("Este programa irá pedir o índice de poluição e informar se estão aceitáveis ou não!");
                Console.WriteLine();

                Console.WriteLine("Digite o índice de poluição: ");
                double indice = Convert.ToDouble(Console.ReadLine());

                if (indice >= 0.05 && indice <= 0.25)
                {
                    Console.WriteLine("Índice de poluição aceitável.");
                }
                else if (indice >= 0.3 && indice < 0.4)
                {
                    Console.WriteLine("As indústrias do 1º grupo devem suspender suas atividades.");
                }
                else if (indice >= 0.4 && indice < 0.5)
                {
                    Console.WriteLine("As indústrias do 1º e 2º grupo devem suspender suas atividades.");
                }
                else if (indice >= 0.5)
                {
                    Console.WriteLine("Todos os grupos devem paralisar suas atividades.");
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N): ");
                resposta = Console.ReadLine();
            }
            while (resposta.ToUpper() != "S");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
