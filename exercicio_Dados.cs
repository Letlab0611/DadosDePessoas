using System;

namespace exercicio
{

    class Program
    {


        static void Main(string[] args)
        {
            //declarando variáveis
            string nameOne;
            string nameTwo;
            int age1;
            int age2;
            //pede os nomes e idades
            Console.WriteLine("digite o primeiro nome");
            nameOne = Console.ReadLine();
            //limpa o texto para não po
            Console.WriteLine("digite a primeira idade");
            //converte a idade string para int
            age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o segundo nome");
            nameTwo = Console.ReadLine();

            Console.WriteLine("digite a segunda idade");
            age2 = Convert.ToInt32(Console.ReadLine());
            //mostra qual idade é maior e declara seu nome

            if (age1 > age2)
            {
                Console.WriteLine("PESSOA MAIS VELHA: " + nameOne);
            }
            else
            {
                Console.WriteLine("PESSOA MAIS VELHA: " + nameTwo);
            }

        }
    }
}