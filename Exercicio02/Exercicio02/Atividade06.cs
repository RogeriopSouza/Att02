using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Atividade06
    {
        public static void Executar()
        {
            //Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.
            //A fórmula de conversão de temperatura a ser utilizada é F = (9* C + 160) / 5,
            //em que a variável F representa é a temperatura em graus Fahrenheit e a variável C
            //representa é a temperatura em graus Celsius. 

            Console.WriteLine("converta graus Celsius em Fahreneit");
            Console.WriteLine();
            Console.WriteLine("Informe a temperatura em CELSIUS!!");
            Double C = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Double F = (9 * C + 160) / 5;
            Console.WriteLine();
            Console.WriteLine("A temperatura em CELSIUS de: " + C + "º equivale em Fahreneit e á: " + F);
            Console.ReadKey();
            Console.Clear();


        }
    }
}
