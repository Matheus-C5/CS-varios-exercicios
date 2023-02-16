using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qual_A_Sua_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nascimento, Atual;

            Console.Clear();
            Console.WriteLine("Escreva o ano de seu nascimento:");
            Nascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o ano atual:");
            Atual = int.Parse(Console.ReadLine());
            Console.WriteLine(Atual + " - " + Nascimento + " = " + (Atual - Nascimento));

            if (Atual - Nascimento <= 3)
            {
                Console.WriteLine("você é um bebê");

            }

            else if (Atual - Nascimento <= 9)
            {
                Console.WriteLine("você é um(uma) criança");
            }

            else if (Atual - Nascimento <= 13)
            {
                Console.WriteLine("você é um(uma) pré adolescente");
            }

            else if (Atual - Nascimento <= 17)
            {
                Console.WriteLine("você é um(uma) adolescente");
            }

            else if (Atual - Nascimento <= 35)
            {
                Console.WriteLine("você é um(uma) jovem");
            }

            else if (Atual - Nascimento <= 59)
            {
                Console.WriteLine("você é um(uma) adulto(a)");
            }

            else if (Atual - Nascimento <= 100)
            {
                Console.WriteLine("você é um(uma) idoso(a)");
            }


            {
                Console.ReadKey();
            }
        }
    }
}
