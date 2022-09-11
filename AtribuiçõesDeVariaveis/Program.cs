using System;

namespace AtribuiçõesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atribuiuções de variaveis!");
            int idade = 32;
            int idadeLucas = idade;

            Console.WriteLine(" A idade de Lucas é: " + idadeLucas);

            Console.WriteLine("Aqui agora irei mostar o poder da Hierarquia do C#");
            Console.WriteLine("Nova varivavel ->"+idade);// aaqui ira sair novamente o mesmo valor, pois a variavel que esta sendo recareegada mais a baixo está fora da herarquia.
             
            
            idade = 33;// Uma variavel recarregada, precsio sempre lembrar que para que o valor dela seja aceito ou impresso.

            //podem hver erros se:

            int numero = 1,2;// Não se pode declarar tipos Reais em bariaveis Inteiras, esse erro é chamdo de Type Mismatch

            //O C# Aceita:
            double numero2 = 10;//Como o tipo Double é maior que tipos inteiros, então ele aceita.
            
            //Fazendo um Type Casting, ou convertento valores
            int numeroTeste = (int)10.2;//Está explícito que será feito o cast de double para inteiro.
          

        }
    }
}
