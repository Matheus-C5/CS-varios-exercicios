using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analise_Números_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string vResp;
            do
            {
                Console.Clear();
                int[] N = new int[10];
                int x, contPar = 0, contImpar = 0, vMaior = 0, vMenor = 0;
                double vTtl = 0, vMedia = 0;

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

                }
                for (x = 0; x < N.Length; x++)
                {
                    vTtl += N[x];
                    vMedia = vTtl / 10;
                }
                for (x = 0; x < 10; x++)
                {
                    if (N[x] > 0)
                    {
                        vMaior = N[x];
                        vMenor = N[x];
                        for (x = 0; x < 10; x++)
                        {
                            if (vMaior < N[x])
                            {
                                vMaior = N[x];
                            }

                            if (vMenor > N[x])
                            {
                                vMenor = N[x];
                            }
                        }
                    }
                }
                Console.WriteLine("Foram digitados {0} nº par(es)", contPar);
                Console.WriteLine("Foram digitados {0} nº ímpar(es)", contImpar);
                Console.WriteLine("A soma dos números é igual a " + vTtl);
                Console.WriteLine("A média dos números é iguel a " + vMedia);
                Console.WriteLine("O maior número é " + vMaior);
                Console.WriteLine("O menor número é " + vMenor);
                Console.WriteLine("Deseja continuar? (S/N)");
                vResp = Console.ReadLine();
            } while (vResp != "N" && vResp != "n");
        }
    }
}
