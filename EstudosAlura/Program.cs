using System;//Bibliotecas para uso de Diposing

//Conversão de Nomeclatura
//Todas as declaralções de variaveis precisam respeitar os seus tipos, como:
//Came Case = Quando o começa com a primeira letra minuscual e as demais MAIUSCULA
//Pascal Case = Quando tanto a Primeira como a Segunda Letra começa em MAIUSCULA
//Snake Case = Quando se utilizando o Underline (_) para separar as palavras, pode ser MAiuscula, como Minuscula
//Kebab Case = Quando se utilizando o Traço (-) para separar as palavras, pode ser MAiuscula, como Minuscula

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração de variaveis Inteiras
                int idade;
            Console.Write("Declaração de Variaveis do Tipo Inteiro!");

            Console.Write("Digite um numero Inteiro:");
            idade =int.Parse(Console.ReadLine());
            Console.WriteLine("O numero digitado foi: " + idade);
            Console.WriteLine($"O numero digitado foi:{idade} ");

            // declaração de variaveis Ponto Fluantes 



        }

        public class Pessoa
        {
            public void Abrir()
            {
                Console.WriteLine("Abrindo uma porta");
            }

            public void Abrir(bool abrir)
            {
                Console.WriteLine("Abrindo uma janela");
            }

            public void Abrir(string abrir)
            {
                Console.WriteLine($"Abrindo um(a) {abrir}");
            }
        }
    }

}
