using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estado_e_Sigla_Vetor_e_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string vTexto, vResp;
            string[,] Estado = new string[27, 2];
            Estado[0, 0] = ("SP"); Estado[0, 1] = ("São Paulo");
            Estado[1, 0] = ("AC"); Estado[1, 1] = ("Acre");
            Estado[2, 0] = ("AL"); Estado[2, 1] = ("Alagoas");
            Estado[3, 0] = ("AM"); Estado[3, 1] = ("Amazonas");
            Estado[4, 0] = ("BA"); Estado[4, 1] = ("Bahia");
            Estado[5, 0] = ("CE"); Estado[5, 1] = ("Ceará");
            Estado[6, 0] = ("DF"); Estado[6, 1] = ("Distrito Federal");
            Estado[7, 0] = ("ES"); Estado[7, 1] = ("Espírito Santo");
            Estado[8, 0] = ("GO"); Estado[8, 1] = ("Goiás");
            Estado[9, 0] = ("MA"); Estado[9, 1] = ("Maranhão");
            Estado[10, 0] = ("MT"); Estado[10, 1] = ("Mato Grosso");
            Estado[11, 0] = ("MS"); Estado[11, 1] = ("Mato Grosso do Sul");
            Estado[12, 0] = ("MG"); Estado[12, 1] = ("Minas Gerais");
            Estado[13, 0] = ("PA"); Estado[13, 1] = ("Pará");
            Estado[14, 0] = ("PB"); Estado[14, 1] = ("Paraíba");
            Estado[15, 0] = ("PR"); Estado[15, 1] = ("Paraná");
            Estado[16, 0] = ("PE"); Estado[16, 1] = ("Pernambuco");
            Estado[17, 0] = ("PI"); Estado[17, 1] = ("Piauí");
            Estado[18, 0] = ("RJ"); Estado[18, 1] = ("Rio de Janeiro");
            Estado[19, 0] = ("RN"); Estado[19, 1] = ("Rio Grande do Norte");
            Estado[20, 0] = ("RS"); Estado[20, 1] = ("Rio Grande do Sul");
            Estado[21, 0] = ("RO"); Estado[21, 1] = ("Rondônia");
            Estado[22, 0] = ("RR"); Estado[22, 1] = ("Roraima");
            Estado[23, 0] = ("SC"); Estado[23, 1] = ("Santa Catarina");
            Estado[24, 0] = ("SE"); Estado[24, 1] = ("Sergipe");
            Estado[25, 0] = ("TO"); Estado[25, 1] = ("Tocantins");
            Estado[26, 0] = ("AP"); Estado[26, 1] = ("Amapá");
            do
            {
                Console.Clear();

                Console.Write("Digite uma Sigla ou Estado: ");
                vTexto = Console.ReadLine();

                for (x = 0; x < 27; x = x + 1)
                {
                    if (vTexto == Estado[x, 0])
                    {
                        Console.WriteLine(vTexto + " é a sigla do estado de " + Estado[x, 1]);
                        break;

                    }

                    if (vTexto == Estado[x, 1])
                    {
                        Console.WriteLine(vTexto + " é um estado que tem a sua sigla " + Estado[x, 0]);
                        break;
                    }
                }


                if (x > 27)
                {
                    Console.WriteLine("Estado ou Sigla inválido");
                }
                Console.WriteLine("Deseja continuar? (S/N)");
                vResp = Console.ReadLine();
            } while (vResp != "N" && vResp != "n");
        }
    }
}
