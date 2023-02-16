using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Mês_ou_Dia
{
    class Program
    {
        static void Main(string[] args)
        {
            string vOpc, vResp;

            do
            {
                do
                {
                    Console.Clear();
                    Console.Write("Digite uma opção?(D/M)");
                    vOpc = Console.ReadLine();
                    if (vOpc == "D" || vOpc == "d")
                    {
                        string[] Dia = new string[8];
                        int N;

                        Dia[1] = "Domingo";
                        Dia[2] = "Segunda-Feira";
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
                    }
                    else if (vOpc == "M" || vOpc == "m")
                    {
                        string[] Mês = new string[13];

                        int M;

                        Mês[1] = "Janeiro";
                        Mês[2] = "Fevereiro";
                        Mês[3] = "Março";
                        Mês[4] = "Abril";
                        Mês[5] = "Maio";
                        Mês[6] = "Junho";
                        Mês[7] = "Julho";
                        Mês[8] = "Agosto";
                        Mês[9] = "Setembro";
                        Mês[10] = "Outubro";
                        Mês[11] = "Novembro";
                        Mês[12] = "Dezembro";

                        Console.Write("Digite um número: ");
                        M = int.Parse(Console.ReadLine());

                        if (M < 1 || M > 12)
                        {
                            Console.WriteLine("Mês Inválido");
                        }
                        else
                        {
                            Console.WriteLine("{0} corresponde a {1}", M, Mês[M]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida.");
                    }
                    Console.WriteLine("Deseja continuar? (S/N)");
                    vResp = Console.ReadLine();
                } while (vResp != "N" && vResp != "n");
            } while (vOpc != "N" && vOpc != "n");
        }
    }
}
