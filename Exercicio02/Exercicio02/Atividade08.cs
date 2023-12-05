using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
     public class Atividade08
    {
        public static void Executar()
        {
            //Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula: 
            //V = 3.14159 * R * R * A 
            // Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.

            Console.WriteLine("volume de uma lata de óleo ");
            Console.WriteLine();
            Console.WriteLine("Infome a Altura da lata de óleo!! ");
            Double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Infome o Raio da lata de óleo!! ");
            Double R = double.Parse(Console.ReadLine());

            Double Volume = 3.14159 * R * R * A;

            Console.WriteLine("o vlume em litros desta lata de Oléo e de: " + Volume + " lts");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
