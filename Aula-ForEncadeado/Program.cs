using System;

namespace Aula_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encadeando FOR");
            Console.WriteLine("Imrpimindo uma cadeia de Cartarteres em Linas e Colunas");

            for (int contadorLinhas=0; contadorLinhas<=10;contadorLinhas++)
            {
                for (int contadorColunas=0; contadorColunas<=contadorLinhas; contadorColunas++)
                {
                    //qui também poderia ser imIF,
                    //para que pudesse testar(contadorColunas<=contadorLinhas)
                    //ainde ser umtilizado um Break para pausar o teste
                    Console.Write("*");//Essa saida é reposavel por colocar o *

                }
                Console.WriteLine("");// Essa saida é resposavel por o pulo de uma Linha!
            }

        }
    }
}
