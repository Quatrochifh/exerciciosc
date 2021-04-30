using System;

namespace Exercicio_3_reajuste
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("insira seu nome\n");
            string nomeDaPessoa = Console.ReadLine();

            Console.WriteLine("Olá " + nomeDaPessoa + "!!!");

            Console.WriteLine("qual o seu salario atualmente?");
            double salarioatual = double.Parse(Console.ReadLine());

             if(salarioatual < 500){

               double salarioporcento = (salarioatual * 30)/100 ;
               double salariocerto = salarioatual + salarioporcento;
               
               Console.WriteLine("Seu novo salario é: " + salariocerto);
            }
            

            else{
                Console.WriteLine("Você não tem direito ao reajuste atual da empresa");
            }

        }
    }
}
