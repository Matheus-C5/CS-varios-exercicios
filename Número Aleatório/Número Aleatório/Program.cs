using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_Aleatório
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int N, P;
            string vResp;

            do
            {
                Console.Clear();
                Console.Write("Digite um número:");
                P = int.Parse(Console.ReadLine());
                N = aleatorio.Next(0, 6);
                Console.WriteLine("O número gerado foi " + N);
                N = aleatorio.Next(0, 6);
                Console.WriteLine("O segundo número gerado foi " + N);

                if (P == N)
                {
                    Console.WriteLine("Você acertou!");
                }

                else if (P != N)
                {
                    Console.WriteLine("Você errou!");
                    Console.Write("Digite outro número: ");
                    P = int.Parse(Console.ReadLine());
                    N = aleatorio.Next(0, 6);
                    Console.WriteLine("O número gerado foi " + N);
                    N = aleatorio.Next(0, 6);
                    Console.WriteLine("O segundo número gerado foi " + N);
                    Console.WriteLine("Você errou de novo");

                    Console.Write("Digite outro número: ");
                    P = int.Parse(Console.ReadLine());
                    N = aleatorio.Next(0, 6);
                    Console.WriteLine("O número gerado foi " + N);
                    N = aleatorio.Next(0, 6);
                    Console.WriteLine("O segundo número gerado foi " + N);
                    Console.WriteLine("Você errou mais uma vez");
                }

                Console.WriteLine("Deseja continuar? (S/N)");
                vResp = Console.ReadLine();
            } while (vResp != "N" && vResp != "n");
            while (true) ;
        }
    }
}
