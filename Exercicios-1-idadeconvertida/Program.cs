using System;

namespace Exercicios_1_idadeconvertida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é seu nome ?");
            string nomePessoa = Console.ReadLine();

            Console.WriteLine("ola! " + nomePessoa + "!!" + "\n");

            Console.WriteLine("Quantos anos você tem?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("okay " + nomePessoa + " você tem..." + "\n");

            int meses = idade * 12;
            Console.WriteLine(meses + " meses" );

            int ano = idade * 366;
            Console.WriteLine(ano + " dias em anos");
            
            int dias = idade * 365;
            Console.WriteLine(dias + " dias" );
            
            int horas = dias * 365;
            Console.WriteLine(horas + " horas");

            int minutos = horas * 60;
            Console.WriteLine(minutos + "min");

            Console.WriteLine("Obrigado " + nomePessoa );

        }
    }
}
