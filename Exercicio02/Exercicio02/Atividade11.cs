using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Atividade11
    {
        public static void Executar()
        {
            //Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de modo que a variável A passe a 
            //possuir o valor da variável B, e a variável B passe a possuir o valor da variável A.Apresentar os valores trocados.


            Console.WriteLine("informe dois valores inteiros A e B e no final sera mostrado em ordem trocas");
            Console.WriteLine();
            Console.WriteLine("Informe o PRIMEIRO NÚMERO (A)!!");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o SEGUNDO  NÚMERO (B)!!");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine($"Os dois valores foram digitados na seguinte ordem {A} {B}");

            // ESTA PARTE TIVE QUE PESQUISAR POIS NÃO SABIA 

            int aux = A; // esta é uma varialvel auxiliar e serve para armazenzar temporariamente o valor de A
            A = B;
            B = aux;


            Console.WriteLine("Os valores trocados são: A = " + A + " e B = " + B);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
