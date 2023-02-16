using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Mês
{
    class Program
    {
        static void Main(string[] args)
        {
                string[] Mes = new string[13];
                Mes[0] = "Nada";
                Mes[1] = "Janeiro";
                Mes[2] = "Fevereiro";
                Mes[3] = "Março";
                Mes[4] = "Abril";
                Mes[5] = "Maio";
                Mes[6] = "Junho";
                Mes[7] = "Julho";
                Mes[8] = "Agosto";
                Mes[9] = "Setembro";
                Mes[10] = "Outubro";
                Mes[11] = "Novembro";
                Mes[12] = "Dezembro";


                int numero;
                Console.Clear();
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());


                if (numero < 1 || numero > 12)
                {
                    Console.WriteLine("Mês Inválido");
                }
                else
                {
                    Console.WriteLine("{0} corresponde a {1}", numero, Mes[numero]);
                }
                Console.ReadKey();
            }
    }
}
