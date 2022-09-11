using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vido ao programe de multipla escolha!");

            int opc;
            string nome;
            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();


            Console.WriteLine("Escolha uma das Opções a baixo para Interagir com o sistema!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1 - Cadastrar nomes");
            Console.WriteLine("2 - Somar Notas");
            Console.WriteLine("3 - Sair do programa");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");
            opc = int.Parse(Console.ReadLine());

            switch(opc){


                case 1:
                    Console.WriteLine("Aqui sera o cadastro de nomes!");
                    break;

                case 2:
                    Console.WriteLine("Aqui será o somatorio de notas!");
                    break;

                case 3:
                    
                    break;



            }

            
        }
    }
}
