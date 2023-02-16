using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, media;
            string resposta;
            do
            {

                Console.Clear();
                Console.WriteLine("Digite a primeira nota:");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota:");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a terceira nota:");
                n3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quarta nota:");
                n4 = int.Parse(Console.ReadLine());
                media = (n1 + n2 + n3 + n4) / 4;
                Console.WriteLine("A sua média é");
                Console.WriteLine(media);

                if (media <= 5)
                {
                    Console.WriteLine("Você esta insatisfatório.");
                }
                else if (media <= 7.5)
                {
                    Console.WriteLine("Você esta regular.");

                }
                else if (media <= 9.5)
                {
                    Console.WriteLine("Você esta bom.");

                }

                else
                {
                    Console.WriteLine("Você esta muito bom.");

                }
                Console.WriteLine("Deseja continuar? (S/N)");
                resposta = Console.ReadLine();
            } while (resposta != "N" && resposta != "n");
        }
    }
}
