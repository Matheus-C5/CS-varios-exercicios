using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_e_Contadores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Dia = new string[8];
            string vFrase, vLetra, resposta;
            int vQtdLetras, i, cont_a;

            do
            {

                Console.Clear();
                Console.Write("Digite uma frase: ");
                vFrase = Console.ReadLine();
                vQtdLetras = vFrase.Length;
                Console.WriteLine("Essa frase tem {0} letras", vQtdLetras);
                Console.WriteLine("Tudo em maiúsculo :");
                Console.WriteLine(vFrase.ToUpper());
                Console.WriteLine("Tudo em minúsculo :");
                Console.WriteLine(vFrase.ToLower());
                cont_a = 0;
                for (i = 0; i < vQtdLetras; i = i + 1)
                {
                    vLetra = vFrase.Substring(i, 1);
                    if (vLetra.ToUpper() == "A")
                    {
                        cont_a++; //cont_a = cont_a + 1;

                    }


                }//fecha o for
                Console.WriteLine("A frase tem {0} letra(s) 'a' ", cont_a);


                Console.Write("Deseja continuar? Digite S/s para sim e N/n para não ");
                resposta = Console.ReadLine();
            } while (resposta != "N" && resposta != "n");
        }
    }
}
