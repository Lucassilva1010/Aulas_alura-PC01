using System;

namespace Aula_Para
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula para, simulando ainda um investimento!");

            int mes;
            double investimento, taxa, porcetagemInvestimento;

            Console.WriteLine("Qauanto você pretende investir? ");
            investimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a Taxa de Juros que você pretende aplicar? \nNão coloque o %!");
            porcetagemInvestimento = double.Parse(Console.ReadLine());
            taxa = porcetagemInvestimento / 100; 
            Console.WriteLine("Em quanto tempo você pretende receber o seu investimento?");
            mes = int.Parse(Console.ReadLine());

            for (int i =1; i<=mes; i++)// a diferaça para o while, é que eu posso declarar os parâmetros dentro da minha decisão
            {
                investimento = investimento + (investimento * taxa);
                Console.WriteLine("O seu investimento no "+i+"ª mês será de:  "+investimento);
            }

        }
    }
}
