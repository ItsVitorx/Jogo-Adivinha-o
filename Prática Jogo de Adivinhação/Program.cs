using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prática_Jogo_de_Adivinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int min = 1;
            int max = 100;
            bool JogarDnv = true;
            int tentativa = 0;
            int tentativas = 0;
            int number = 0;
            string resposta = "";

            while (JogarDnv)
            {
                tentativa = 0;
                tentativas = 0;
                resposta = "";
                number = random.Next(min, max + 1);

                while (tentativa != number)
                {
                    Console.WriteLine("Chute um número entre 1 e 100");
                    tentativa = int.Parse(Console.ReadLine());

                    if (tentativa < number)
                    {
                        Console.WriteLine("Você chutou números abaixo!");
                    }
                    else if (tentativa > number)
                    {
                        Console.WriteLine("Você chutou números acima!");
                    }
                    tentativas++;

                }
                Console.WriteLine("Você Ganhou!");
                Console.WriteLine("Tentativas até conseguir acertar: " + tentativas);
                Console.WriteLine("Numéro: " + number);
                Console.WriteLine("Gostaria de jogar de novo? (S/N)");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();

                if (resposta == "S")
                {
                    JogarDnv = true;
                }
                else
                {
                    JogarDnv = false;
                }
            }
            Console.WriteLine("Obrigado por jogar!");
            Console.ReadLine();





        }
    }
}
