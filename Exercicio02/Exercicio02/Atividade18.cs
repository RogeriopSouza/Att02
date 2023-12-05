using System;



namespace Exercicio02
{
    public class Atividade18
    {
        public static void Executar()
        {
            Console.WriteLine("Informe um número e o console dirá se é válido ou não e mostrará na tela.");
            Console.WriteLine();

            Console.Write("Digite um número inteiro: ");
            Console.WriteLine();

            if (int.TryParse(Console.ReadLine(), out int codigo))
            {
                switch (codigo)
                {
                    case 1:
                        Console.WriteLine("UM - Este é um número válido!");
                        break;
                    case 2:
                        Console.WriteLine("Dois - Este é um número válido!");
                        break;
                    case 3:
                        Console.WriteLine("TRÊS - Este é um número válido!");
                        break;
                    default:
                        Console.WriteLine("CÓDIGO INVÁLIDO");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de digitar um número inteiro.");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}

