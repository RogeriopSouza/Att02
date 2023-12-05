using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Atividade62
    {
        public static void Executar()
        {
            Console.Write("Digite o valor da base: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            double hipotenusa = Hipotenusa(baseTriangulo, alturaTriangulo);

            Console.WriteLine($"O valor da hipotenusa é {hipotenusa}.");
            Console.ReadLine();
            Console.Clear();
        }

        static double Hipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            return Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));

        }
    }
}
