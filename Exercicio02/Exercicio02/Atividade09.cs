using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public  class Atividade09
    {
        public static void Executar()
        {
            //Faça um algoritmo que leia a idade de uma pessoa expressa em anos,
            //meses e dias e escreva a idade dessa pessoa expressa apenas em dias.Considerar ano com 365 dias e mês com 30 dias.
            // Obs. vou montar de acordo com o que eu acho logico pois não faz sentido a pessoa informar a idade em dias
            // e mostrar o mesmo que ela ja digitou
            // este é um codigo bem simples 

            Console.WriteLine("informe sua dada de aniversaio e saiba quantos dias você ja  viveu!");
            Console.WriteLine();
            Console.WriteLine("informe o ANO do seu nascimento!");
            int AN = int.Parse(Console.ReadLine());

            Double Anos = 2023 - AN;
            Double Meses = Anos * 12;
            double Dias = Meses * 30;

            Console.WriteLine("se você nasceu em: " + AN + " você já está com : " + Anos + " anos e " + Meses + " e " + Dias + " Dias");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
