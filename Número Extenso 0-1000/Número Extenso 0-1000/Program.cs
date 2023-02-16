using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_Extenso_0_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] unidade = {"zero","um","dois","três","quatro","cinco","seis","sete","oito","nove","dez","onze","doze","treze","quatorze","quinze",
            "dezesseis", "dezessete","dezoito","dezenove"};
            string[] dezena = { "", "", "Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta", "Setenta", "Oitenta", "Noventa" };
            string[] centena = {"", "Cento", "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos", "Seiscentos",
            "Setecentos", "Oitocentos", "Novecentos" };

            int n, nd, ne, nce, ncd;
            string vResp;
            do
            {
                Console.Clear();
                Console.Write("Informe o número: ");
                n = int.Parse(Console.ReadLine());

                if (n < 0 || n > 1000)
                {
                    Console.Write("Esperado de 0 - 1000");
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
                        Console.Write(" e " + unidade[nd]);
                    }


                }
                else if (n < 1000)
                {
                    nce = n / 100;
                    ncd = n % 100;
                    ne = ncd / 10;
                    nd = ncd % 10;

                    if (ncd > 0 && ncd < 10 && ne == 0)
                    {
                        Console.Write(centena[nce] + " e " + unidade[ncd]);
                    }
                    else if (n == 100)
                    {
                        Console.Write("Cem");
                    }
                    else if (ncd < 20 && ncd > 9 && ne > 0)
                    {
                        Console.Write(centena[nce] + " e " + unidade[ncd]);
                    }
                    else if (ncd == 0 && ne == 0)
                    {
                        Console.Write(centena[nce]);
                    }
                    else if (nd == 0)
                    {
                        Console.Write(centena[nce] + " e " + dezena[ne]);
                    }
                    else if (n > 99)
                    {
                        Console.Write(centena[nce] + " e " + dezena[ne] + " e " + unidade[nd]);
                    }
                }
                else if (n == 1000)
                {
                    Console.Write("Mil");
                }
                Console.Write("\n");
                Console.Write("Deseja continuar? (S/N)");
                vResp = Console.ReadLine();
            } while (vResp != "N" && vResp != "n");
        }
    }
}
