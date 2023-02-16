using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analise_Números_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] N = new int[10];
                int x, contPar = 0, contImpar = 0, vTotal = 0, oMaior = 0, oMenor = 0, pma = 0, pme = 0;
                string vResp;
                do
                {
                    Console.Clear();
                    contPar = 0; contImpar = 0; vTotal = 0; oMaior = 0; oMenor = 0; pma = 0; pme = 0; //Ajusta posição para contagem
                    for (x = 0; x < 10; x++)
                    {
                        Console.Write("Informe o {0}º número: ", x + 1);
                        N[x] = int.Parse(Console.ReadLine());
                    }
                    for (x = 0; x < 10; x++)
                    {
                        if (N[x] % 2 == 0)
                        {
                            contPar++;
                        }
                        else
                        {
                            contImpar++;
                        }
                        vTotal = vTotal + N[x];
                        if (N[x] > oMaior)
                        {
                            oMaior = N[x];
                            pma = x;
                        }
                        if ((N[x] < oMenor) || (x == 0))
                        {
                            oMenor = N[x];
                            pme = x;
                        }
                    }
                    Console.WriteLine("Total de pares: " + contPar);
                    Console.WriteLine("Quantidade de impares: " + contImpar);
                    Console.WriteLine("Somatória = {0}", vTotal);
                    Console.WriteLine("Maior nº {0} na posição {1} ", oMaior, pma = pma + 1);
                    Console.WriteLine("Menor nº {0} na posição {1} ", oMenor, pme = pme + 1);
                    Console.WriteLine("Média={0}", (double)vTotal / 10);
                    Console.WriteLine("Deseja continuar? (S/N)");
                    vResp = Console.ReadLine();
                } while (vResp != "N" && vResp != "n");
            }
    }
}
