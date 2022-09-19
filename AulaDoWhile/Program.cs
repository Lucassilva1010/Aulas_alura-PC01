using System;

namespace AulaDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apresentando o DO WHILE");

            int a = 1, b=30;
            do
            {
                Console.WriteLine(a);

                a+=1;
            } while (a>b);
        }
    }
}
