using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos_De_2_A_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2;

            Console.Clear();
            Console.WriteLine("Digite um numero:");
            N1 = int.Parse(Console.ReadLine());

            for (N2 = 1; N2 <= 100; N2++)
            {
                Console.WriteLine(N1 + " * " + N2 + " = " + (N1 * N2));
            }

            {
                Console.ReadKey();
            }
        }
    }
}
