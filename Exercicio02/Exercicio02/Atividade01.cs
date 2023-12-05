using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
        public   class Atividade01
    {
        public static void Executar()
        {
            // faça um programa que para calcular o estoque médio de um produto sendo que: 
            // ESTOQUE MEDIO =(QUANTIDADE MINIMA_QUANTIDADE_MAXIMA)/2

            Console.WriteLine("CALCULO MÉDIA DE ESTOQUE MINIMO E MAXIMO");
            Console.WriteLine("insira o NOME do prodtuto");
            string Nome = Console.ReadLine();
            Console.WriteLine("insira o estoque minimo do prodtuto");
            int minimo = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o estoque MAXIMO do prodtuto");
            int maximo = int.Parse(Console.ReadLine());

            int media = minimo + maximo / 2;

            Console.WriteLine("a media do produto " + Nome + "é:" + media);

            Console.ReadKey();
            Console.Clear();

        }
    }
}
