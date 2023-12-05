using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Atividade07
    {
        public static void Executar()
        {
            // Ler uma temperatura em graus Fahrenheit e apresentá-la convertida em graus Celsius.
            // A fórmula de conversão de temperatura a ser utilizada é C = (F - 32) * 5 / 9,
            // em que a variável F é a temperatura em graus Fahrenheit e a variável C é a temperatura em graus Celsius.


            Console.WriteLine("converta graus Fahreneit em Celsius");
            Console.WriteLine();
            Console.WriteLine("Informe a temperatura em Fahreneit!!");
            Double F = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Double C = (F - 32) * 5 / 9;
            Console.WriteLine("A temperatura em Fahreneit de: " + F + " equivale em Celsius e á: " + C.ToString("#0.00º"));
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

        }
    }
}
