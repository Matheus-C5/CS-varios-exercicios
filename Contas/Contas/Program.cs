using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            Console.Clear();
            Console.WriteLine("Digite um numero:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            B = int.Parse(Console.ReadLine());

            {
                Console.WriteLine(A + " + " + B + " = " + (A + B));
            }

            {
                Console.WriteLine(A + " - " + B + " = " + (A - B));
            }

            {
                Console.WriteLine(A + " * " + B + " = " + (A * B));
            }

            {
                Console.WriteLine(A + " / " + B + " = " + (A / B));
            }

            {
                Console.WriteLine(A + " % " + B + " = " + (A % B));
            }

            {
                Console.WriteLine(A + " ^ " + B + " = " + (A ^ B));
            }

            {
                Console.ReadKey();
            }
        }
    }
}
