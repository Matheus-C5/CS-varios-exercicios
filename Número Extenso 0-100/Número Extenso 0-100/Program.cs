using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_Extenso_0_100
{
    class Program
    {
        static void Main(string[] args)
        {
            string vResp;
            string[] unidade = { "zero","um","dois","três","quatro","cinco","seis","sete","oito","nove","dez","onze","doze","treze","quatorze","quinze",
            "dezesseis", "dezessete","dezoito","dezenove"};
            string[] dezena = { "", "", "Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta", "Setenta", "Oitenta", "Noventa" };

            int n, nd, ne;
            do
            {
                Console.Clear();
                Console.Write("Informe o número: ");
                n = int.Parse(Console.ReadLine());

                if (n < 0 || n > 100)
                {
                    Console.WriteLine("Esperado de 0 - 100");
                }
                else if (n < 20)
                {
                    Console.Write(unidade[n]);
                }
                else if (n < 100)
                {
                    ne = n / 10;
                    Console.Write(dezena[ne]);
                    nd = n % 10;
                    if (nd > 0)
                    {
                        Console.WriteLine(" e " + unidade[nd]);
                    }
                    else if (n == 100)
                    {
                        Console.WriteLine("Cem");
                    }
                    else if (n < 1000)
                    {

                    }

                }
                Console.WriteLine("Deseja continuar? (S/N)");
                vResp = Console.ReadLine();
            } while (vResp != "N" && vResp != "n");
        }
    }
}
