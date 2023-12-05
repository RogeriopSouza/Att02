﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Atividade19
    {
        public static void Executar()
        {
            Console.WriteLine("Este código irá dirzer que tipo de triagugo de acordo com os números digitados ");
            Console.WriteLine();

            Console.Write("Digite o valor do lado A do triângulo: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do lado B do triângulo: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do lado C do triângulo: ");
            double C = Convert.ToDouble(Console.ReadLine());

            if (A < B + C && B < A + C && C < A + B)
            {
                if (A == B && B == C)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (A == B || A == C || B == C)
                // O operador || significa “OU”, então se qualquer uma dessas condições
                // for verdadeira (ou seja, se qualquer dois lados forem iguais), então a condição
                // inteira será verdadeira.

                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os valores fornecidos não formam um triângulo.");

            }

        }
    }
}
