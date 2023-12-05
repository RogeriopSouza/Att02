using System;

namespace Exercicio02
{
    public class Atividade48
    {
        public static void Executar()
        {
            // Declare arrays to store names and ages
            string[] nomes = new string[20];
            int[] idades = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Digite o nome da candidata " + (i + 1) + ": ");
                nomes[i] = Console.ReadLine();
                Console.Write("Digite a idade da candidata " + (i + 1) + ": ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Candidatas aptas a concorrer a uma vaga para a campanha milionária:");
            for (int i = 0; i < 20; i++)
            {
                if (idades[i] >= 18 && idades[i] <= 20)
                {
                    Console.WriteLine(nomes[i]);
                }
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
