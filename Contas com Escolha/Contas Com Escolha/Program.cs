using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Com_Escolha
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            string R;


            Console.Clear();
            Console.SetCursorPosition(30, 1);
            Console.WriteLine("Digite um numero:");
            Console.SetCursorPosition(30, 2);
            A = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(30, 5);
            Console.WriteLine("Digite outro numero:");
            Console.SetCursorPosition(30, 6);
            B = int.Parse(Console.ReadLine());


            Console.SetCursorPosition(30, 10);
            Console.Write("+--------------------------------------+");
            Console.SetCursorPosition(30, 11);
            Console.Write("|            [+] Adição                |");

            Console.SetCursorPosition(30, 12);
            Console.Write("+--------------------------------------+");
            Console.SetCursorPosition(30, 13);
            Console.Write("|            [-] Subtração                |");


            Console.SetCursorPosition(30, 14);
            Console.Write("+--------------------------------------+");
            Console.SetCursorPosition(30, 15);
            Console.Write("|            [x] Multiplicação         |");

            Console.SetCursorPosition(30, 16);
            Console.Write("+--------------------------------------+");
            Console.SetCursorPosition(30, 17);
            Console.Write("|            [/] Divisão               |");

            Console.SetCursorPosition(30, 18);
            Console.Write("+--------------------------------------+");
            Console.SetCursorPosition(30, 19);
            Console.Write("|            [^] Potenciação           |");

            Console.SetCursorPosition(30, 20);
            Console.Write("+--------------------------------------+");
            Console.SetCursorPosition(30, 21);
            Console.Write("|            [%] Resto Inteiro         |");


            Console.SetCursorPosition(30, 24);
            Console.WriteLine("Escreva uma operacao:");
            Console.SetCursorPosition(30, 25);
            R = (Console.ReadLine());
            Console.SetCursorPosition(30, 27);


            if (R == "+")
            {
                Console.WriteLine(A + " + " + B + " = " + (A + B));
            }

            else if (R == "-")

            {
                Console.WriteLine(A + " - " + B + " = " + (A - B));
            }
            else if (R == "*")

            {
                Console.WriteLine(A + " * " + B + " = " + (A * B));
            }
            else if (R == "/")

            {
                Console.WriteLine(A + " / " + B + " = " + (A / B));
            }
            else if (R == "%")

            {
                Console.WriteLine(A + " % " + B + " = " + (A % B));
            }
            else if (R == "^")

            {
                Console.WriteLine(A + " ^ " + B + " = " + (A ^ B));
            }

            {
                Console.ReadKey();
            }
        }
    }
}
