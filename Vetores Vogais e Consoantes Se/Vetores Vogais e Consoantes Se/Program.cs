using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Vogais_e_Consoantes_Se
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Dia = new string[8];
            string vFrase, vLetra, resposta;
            int vQtdLetras, i, cont_a, cont_e, cont_i, cont_o, cont_u, cont_consoante;

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
                cont_e = 0;
                cont_i = 0;
                cont_o = 0;
                cont_u = 0;
                cont_consoante = 0;

                for (i = 0; i < vQtdLetras; i = i + 1)
                {
                    vLetra = vFrase.Substring(i, 1).ToLower();
                    if (vLetra == "a")
                    {
                        cont_a++; //cont_a = cont_a + 1;

                    }
                    else if (vLetra == "e")
                    {
                        cont_e++;

                    }
                    else if (vLetra == "i")
                    {
                        cont_i++;

                    }
                    else if (vLetra == "o")
                    {
                        cont_o++;

                    }
                    else if (vLetra == "u")
                    {
                        cont_u++;

                    }
                    else
                    {
                        cont_consoante++;

                    }

                }//fecha o for
                Console.WriteLine("A frase tem {0} vogais 'a' ", cont_a);
                Console.WriteLine("A frase tem {0} vogais 'e' ", cont_e);
                Console.WriteLine("A frase tem {0} vogais 'i' ", cont_i);
                Console.WriteLine("A frase tem {0} vogais 'o' ", cont_o);
                Console.WriteLine("A frase tem {0} vogais 'u' ", cont_u);
                Console.WriteLine("A frase tem {0} consoantes", cont_consoante);


                Console.Write("Deseja continuar? Digite S/s para sim e N/n para não ");
                resposta = Console.ReadLine();
            } while (resposta != "N" && resposta != "n");
        }
    }
}
