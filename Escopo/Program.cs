using System;

namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula Escopo!");
            int idade;

            Console.WriteLine("Quantos anos você tem?");
            idade = int.Parse(Console.ReadLine());

            string resultados;

            //Aqui utilizei o a variavel parta respresentar a forma de carrgar e
            //apresentar uma variavel.
            if (idade >= 18)
            {
                //Essa declação por dentro de um escopo, ele ficará sendo utilizada apenas aqui dentro dele
                //string resultados = "Parabéns você é maior de idade!";
                //................................................

                resultados = "Parabéns você é maior de idade!";
                Console.WriteLine(resultados);
            }
            else//Quando se tem apenas uma instrução apó o Bloco, não precisa fechar com {}
                resultados = "Você não é maior de idade!!";

        }

        //Escopo é uma delimitação do espaço aonde será colocado os seus codigos
        //sempre lembrar que teremos que delimitar e organizar o codio para formarmos
        // bons scripts
    }
}
