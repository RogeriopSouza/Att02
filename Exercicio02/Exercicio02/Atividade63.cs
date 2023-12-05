using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Atividade63
    {
        public static void Executar()
        {
            Console.Write("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            string resultado = Verifica(numero);

            Console.WriteLine($"O número {numero} é {resultado}.");
            Console.ReadLine();
            Console.Clear();
        }

        static string Verifica(int numero)
        {
            if (numero % 2 == 0)
            {
                return "PAR";
            }
            else
            {
                return "ÍMPAR";
            }

        }
    }
}
