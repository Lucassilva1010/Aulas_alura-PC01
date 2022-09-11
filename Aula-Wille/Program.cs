using System;

namespace Aula_Wille
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que simula um Investimento usando o Enquanto - Wille");

            int mes, i = 1;
            double investimento;
            double taxaInvestimento;
            double taxa;

            Console.WriteLine("Quanto que você deseja investir?");
            investimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Quanto tempo(Meses) você pretende investir? ");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("A qual taxa de juros você prefere investir? ");
            taxaInvestimento = double.Parse(Console.ReadLine());
            taxa = taxaInvestimento / 100;


            while (i<=mes)
            {
                investimento = investimento + (investimento*taxa);
                Console.WriteLine("O seu investimento no "+i+"ª mês, será de: "+investimento);
                //POsso utlizar o Incremanto de 3 formar, são elas:
                i++;// essa é forma mais utilizada
                //i = i + 1;
                //i +=;// essa formula pode tando ser par anegativo como para positivo
            }
            


        }
    }
}
