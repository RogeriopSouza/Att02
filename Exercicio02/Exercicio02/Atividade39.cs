using System;

namespace Exercicio02
{
    public class Atividade39
    {
        public static void Executar()
        {
            string resposta;

            do
            {
                Console.WriteLine("Este programa será capaz de ler um número inteiro e dizer se é negativo ou positivo e se é par ou ímpar!");
                Console.WriteLine();

                Console.Write("Digite um número inteiro: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0) // para saber se o número é par ou ímpar    
                {
                    Console.WriteLine("O número é par.");
                }
                else
                {
                    Console.WriteLine("O número é ímpar.");
                }

                if (numero >= 0) // saber se é negativo
                {
                    Console.WriteLine("O número é positivo.");
                }
                else
                {
                    Console.WriteLine("O número é negativo.");
                }

                Console.Write("Deseja encerrar o programa? (S/N): ");
                resposta = Console.ReadLine();
            }
            while (resposta.ToUpper() != "S"); // encerra o programa 

            Console.ReadKey();
            Console.Clear();
        }
    }
}
