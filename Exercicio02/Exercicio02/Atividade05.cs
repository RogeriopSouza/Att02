using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Atividade05
    {
        public static void Executar()
        {
            //Desta forma, será possível obter a distância percorrida com a fórmula
            //DISTANCIA = TEMPO * VELOCIDADE. Tendo o valor da distância, basta calcular a quantidade de
            //litros de combustível utilizada na viagem com a fórmula: LITROS_USADOS = DISTANCIA / 12.
            //O programa deve apresentar os valores da velocidade média, tempo gasto, a distância percorrida
            //e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais. 

            Console.WriteLine("Calculo de combustivel sendo que o carro vaz em media 12km por litro");
            Console.WriteLine();
            Console.WriteLine("infome a MEDIA de consumo do veiculo KM/lt"); // neste caso sera 12km (vou usar este para meu uso) 
            Double MediaLT = double.Parse(Console.ReadLine());
            Console.WriteLine("infome a digite VALOR do LITRO de combustivel");
            Double CustoLT = double.Parse(Console.ReadLine());
            Console.WriteLine("infome o TEMPO ESTIMADO PARA A VIAGEM");
            Double TEMPO = double.Parse(Console.ReadLine());
            Console.WriteLine("infome a VELOCIDADE MÉDIA em KM DURANTE O PERCUSRSO");
            Double Velocidade = double.Parse(Console.ReadLine());

            Double Distancia = TEMPO * Velocidade;
            Double Consumo = Distancia / MediaLT;
            Double Gasto = Distancia / CustoLT;

            Console.WriteLine("A DISTANCIA é de: " + Distancia + " KM");
            Console.WriteLine("o CONSUMO de Combustivel e de: " + Consumo + " LTS");
            Console.WriteLine("O VALOR gasnto nesta viagem e de: R$ " + Gasto.ToString("#0.00"));

            Console.ReadKey();
            Console.Clear();
        }
    }
}
