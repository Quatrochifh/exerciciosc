﻿using System;

namespace EXEMPLOCONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {

        //finalizado!
            Console.BackgroundColor = ConsoleColor.Green;  //só de graça
            Console.WriteLine("qual o seu nome?");
            string nomeDaPessoa = Console.ReadLine();

            Console.WriteLine("Olá " + nomeDaPessoa + "!!!\n");
            Console.WriteLine("em que ano você nasceu??\n");
            int anonas = int.Parse(Console.ReadLine());

            Console.WriteLine("Em qual ano estamos?\n");
            int anonosso = int.Parse(Console.ReadLine());

            //Console.WriteLine(anonas - anonosso+"essa é a sua idade atual");aaaaaaaaaaaaaaaaaaaaaaaaa

            int idade = anonosso - anonas;
            Console.WriteLine("A sua idade é de: " + idade + " anos");

            int idadeSemana = idade * 12 * 4;
            Console.WriteLine("Você viveu por: " +  idadeSemana + " semanas");
        }
    }
}
