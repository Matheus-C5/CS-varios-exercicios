using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Dias
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Dia = new string[8];
            int N;

            Dia[1] = "Domingo";
            Dia[2] = "Segunda=Feira";
            Dia[3] = "Terça-Feira";
            Dia[4] = "Quarta-Feira";
            Dia[5] = "Quinta-Feira";
            Dia[6] = "Sexta-Feira";
            Dia[7] = "Sábado";

            Console.Write("Digite um número: ");
            N = int.Parse(Console.ReadLine());
            if (N < 1 || N > 7)
            {
                Console.WriteLine("Dia Inválido");
            }
            else
            {
                Console.WriteLine("{0} corresponde a {1}", N, Dia[N]);
            }
            Console.ReadKey();
        }
    }
}
