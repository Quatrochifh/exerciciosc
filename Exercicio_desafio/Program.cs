using System;

namespace Exercicio_desafio
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("insira seu nome\n");
            string nomeDaPessoa = Console.ReadLine();

            Console.WriteLine("Olá " + nomeDaPessoa + "!!!");
            
            Console.WriteLine("Qual é a sua idade?");
            int idadePessoa = int.Parse(Console.ReadLine());

            if (idadePessoa < 5)
            {
                Console.WriteLine("Você não tem idade suficiente para participar ");
            }

            else
            {
                if (idadePessoa <= 7)
                {
                    Console.WriteLine("você está na: Infantil A");
                }

                else
                {
                    if (idadePessoa <= 10)
                    {
                        Console.WriteLine("você está na: Infantil B");
                    }


                    else
                    {
                        if (idadePessoa <= 13)
                        {
                            Console.WriteLine("você está na: juvenil A");
                        }

                        else
                        {
                            if (idadePessoa <= 17)
                            {
                                Console.WriteLine("você está na: Juvenil B");
                            }

                            else
                            {
                                
                                    Console.WriteLine("você está na: Sênior");
                            }
                        }
                    }
                }
            }
        }
    }
}
