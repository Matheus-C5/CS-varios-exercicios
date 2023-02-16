using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Vogais_e_Consoantes_Caso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Dia = new string[8];
            string vFrase, vLetra, vResp;
            int vQtd, cont_A, cont_E, cont_I, cont_O, cont_U, CONSO, i;

            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.Write("Digite uma frase aqui oh: ");
                vFrase = Console.ReadLine();
                vQtd = vFrase.Length; //Lenght cat $ for vQtd 
                Console.WriteLine("\nEssa frase tem {0} caracteres", vQtd);
                Console.Write("\nTudo em Maiuscolo: ");
                Console.WriteLine(vFrase.ToUpper());
                Console.Write("\nTudo em Minusculo: ");
                Console.WriteLine(vFrase.ToLower());

                cont_A = 0;
                cont_E = 0;
                cont_I = 0;
                cont_O = 0;
                cont_U = 0;
                CONSO = 0;

                for (i = 0; i < vQtd; i = i + 1) //valor $enquanto até $quando
                {
                    vLetra = vFrase.Substring(i, 1);

                    switch (vLetra.ToUpper())
                    {

                        case "A":
                            {
                                cont_A++;
                                break;
                            }
                        case "E":
                            {
                                cont_E++;
                                break;
                            }
                        case "I":
                            {
                                cont_I++;
                                break;
                            }
                        case "O":
                            {
                                cont_O++;
                                break;
                            }
                        case "U":
                            {
                                cont_U++;
                                break;

                            }
                        case " ":
                            {

                                break;

                            }
                        default:
                            {
                                CONSO++;
                                break;
                            }

                    }

                }
                Console.WriteLine("\n>>> A frase tem vogais \n{0} LETRAS [A] \n{1} LETRAS [E] \n{2} LETRAS [I] \n{3} LETRAS [O] \n{4} LETRAS [U] \n{5} CONSOANTES", cont_A, cont_E, cont_I, cont_O, cont_U, CONSO);
                Console.WriteLine("Deseja continuar? (S/N)");
                vResp = Console.ReadLine();
            } while (vResp != "N" && vResp != "n");

        } //fechar con$ole
    } //fecha cabe$alho
} //fecha $istem