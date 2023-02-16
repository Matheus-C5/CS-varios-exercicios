using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_Ou_Igual
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Clear();
            Console.WriteLine("Digite um numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O primeiro número é maior");
            }

            else if (n2 > n1)
            {
                Console.WriteLine("O segundo número é maior");
            }

            else if (n1 == n2)
            {
                Console.WriteLine("Os dois números são iguais");
            }

            {
                Console.ReadKey();
            }
        }
    }
}
