using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_Ou_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;

            Console.Clear();
            Console.WriteLine("Digite um numero:");
            A = int.Parse(Console.ReadLine());

            if (A % 2 == 0)
            {
                Console.WriteLine("Este número é par.");
            }

            else
            {
                Console.WriteLine("Este número é impar.");
            }

            {
                Console.ReadKey();
            }
        }
    }
}
