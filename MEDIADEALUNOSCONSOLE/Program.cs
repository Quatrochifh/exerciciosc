using System;

namespace MEDIADEALUNOSCONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
           //em verde meus comentarios
           //backgrund cria a cor de fundo do terminal: nesse caso, verde!    
            //Console.BackgroundColor = ConsoleColor.Green; muda a cor do fundo
            //Console.ForegroundColor = ConsoleColor.Yellow; muda a cor so da letra
            Console.WriteLine("Exercicio Media\n");

            Console.WriteLine("insira seu nome\n");
            string nomeDaPessoa = Console.ReadLine();

            Console.WriteLine("Olá " + nomeDaPessoa + "!!!");
            
            Console.WriteLine("Qual é a primeira nota?");
            //int primeiranota = int.Parse (Console.ReadLine());
            double primeiranota = double.Parse(Console.ReadLine());

             Console.WriteLine("Qual é a segunda nota?");
            double segundanota = double.Parse(Console.ReadLine());

             Console.WriteLine("Qual é a terceira nota?");
            double terceiranota = double.Parse(Console.ReadLine());

            double media = (primeiranota + segundanota + terceiranota) /3 ;

            //Console.WriteLine("A média das notas foi:" + media); com varios numeros pós virgula
            Console.WriteLine("A média das notas foi:\n" + Math.Round(media, 2)); //numeros limitados pós virgula
            //Console.WriteLine("A média das notas foi:" + media.ToString("N3")); numeros tbm limitados

            if (media > 5)
            {
                //caso a media seja maior que 5, o aluno sera aprovado
                Console.WriteLine("O aluno foi aprovado!!!");
            } else {
                 //caso a media seja maior que 5, o aluno sera reprovado
                 Console.WriteLine("o aluno foi reprovado!!");
            }

        }
    }
}
