using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Menu_Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            int vOpc;
            do
            {
                //1) Apresentar as opções
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                janela(0, 0, 80, 2);
                janela2(23, 3, 52, 17);
                janela3(0, 18, 80, 20);
                Console.SetCursorPosition(30, 1);
                Console.Write("MENU PRINCIPAL");
                Console.SetCursorPosition(3, 3);
                // Console.Write(new string('-', 80));
                Console.SetCursorPosition(25, 4);
                Console.Write("[1] Cálculos");
                Console.SetCursorPosition(25, 5);
                Console.Write("[2] Compara");
                Console.SetCursorPosition(25, 6);
                Console.Write("[3] Par ou Ímpar");
                Console.SetCursorPosition(25, 7);
                Console.Write("[4] Idade");
                Console.SetCursorPosition(25, 8);
                Console.Write("[5] Corre palavra");
                Console.SetCursorPosition(25, 9);
                Console.Write("[6] Média");
                Console.SetCursorPosition(25, 10);
                Console.Write("[7] Vogais e Consoantes");
                Console.SetCursorPosition(25, 11);
                Console.Write("[8] Mês ou Dia");
                Console.SetCursorPosition(25, 12);
                Console.Write("[9] Analise Números");
                Console.SetCursorPosition(25, 13);
                Console.Write("[10] Estado e Sigla");
                Console.SetCursorPosition(25, 14);
                Console.Write("[11] Número Aleatório");
                Console.SetCursorPosition(25, 15);
                Console.Write("[12] Número Extenso 0-1000");
                Console.SetCursorPosition(25, 16);
                Console.Write("[13] Fim");
                Console.SetCursorPosition(0, 17);
                //Console.Write(new string('-', 80));
                Console.SetCursorPosition(0, 18);
                //Console.Write(new string('-', 80));
                //2) Receber a opção desejada
                Console.SetCursorPosition(28, 19);
                Console.Write("Digite a sua opção: ");
                vOpc = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(0, 24);
                //3) Decide o que fazer conforme opção
                switch (vOpc)
                {
                    case 1:
                        {
                            subMenu_Cálculos();
                            break;
                        }
                    case 2:
                        {
                            Compara();
                            break;
                        }
                    case 3:
                        {
                            Par_ou_Ímpar();
                            break;
                        }
                    case 4:
                        {
                            Idade();
                            break;
                        }
                    case 5:
                        {
                            Corre_palavra();
                            break;
                        }
                    case 6:
                        {
                            Média();
                            break;
                        }
                    case 7:
                        {
                            Vogais_e_Consoantes();
                            break;
                        }
                    case 8:
                        {
                            Mês_ou_Dia();
                            break;
                        }
                    case 9:
                        {
                            Analise_Números();
                            break;
                        }
                    case 10:
                        {
                            Estado_e_Sigla();
                            break;
                        }
                    case 11:
                        {
                            Número_Aleatório();
                            break;
                        }
                    case 12:
                        {
                            Número_Extenso_0_1000();
                            break;
                        }
                    case 13:
                        {
                            Fim();
                            break;
                        }
                    default: // NDA
                        {
                            Console.SetCursorPosition(26, 22);
                            Console.Write("[*****Opção inválida*****]");
                            // Pausa até que algo seja pressionado
                            Console.ReadKey();
                            // -------------------
                            break;
                        }
                }// Fecha o switch
            } while (vOpc != 13); // Fecha o do

        }//fecha o main

        private static void subMenu_Cálculos()
        {
            double n1, n2, soma, subt, div, mult, pot;
            int restoInt;
            string resposta;

            do
            {

                Console.Clear();
                Console.Write("Digite um número: "); //Escreva()
                n1 = double.Parse(Console.ReadLine()); //Leia n1
                Console.Write("Digite um número: "); //Escre()
                n2 = double.Parse(Console.ReadLine()); //Leia n2

                soma = n1 + n2;
                subt = n1 - n2;
                div = n1 / n2;
                mult = n1 * n2;
                pot = Math.Pow(n1, n2);
                restoInt = (int)n1 % (int)n2;

                Console.WriteLine("{0} + {1} = ", n1, n2 + soma);
                Console.WriteLine("{0} - {1} = {2}", n1, n2, subt);
                Console.WriteLine("{0} x {1} = {2}", n1, n2, mult);
                Console.WriteLine("{0} elevado a {1} = {2}", n1, n2, pot);
                Console.WriteLine("{0} / {1} = {2}", n1, n2, div);
                Console.WriteLine("{0} % {1} = {2}", n1, n2, restoInt);

                Console.Write("Deseja continuar? Digite S/s para sim e N/n para não ");
                resposta = Console.ReadLine();
            } while (resposta != "N" && resposta != "n");
        }
        private static void Compara()
        {
            double n1, n2;
            string resposta;

            do
            {

                Console.Clear();
                Console.Write("Digite um número: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("Digite outro número: ");
                n2 = double.Parse(Console.ReadLine());

                if (n1 < n2)
                {
                    Console.WriteLine(n1 + " é menor que " + n2);
                }
                else if (n1 > n2)
                {
                    Console.WriteLine(n1 + " é maior que " + n2);
                }
                else if (n1 == n2)
                {
                    Console.WriteLine(n1 + " é igual à " + n2);
                }

                Console.Write("Deseja continuar? Digite S/s para sim e N/n para não ");
                resposta = Console.ReadLine();
            } while (resposta != "N" && resposta != "n");
        }
        private static void Par_ou_Ímpar()
        {
            double n1;
            string resposta;

            do
            {

                Console.Clear();
                Console.Write("Digite um número: ");
                n1 = double.Parse(Console.ReadLine());

                if (n1 % 2 == 0)
                {
                    Console.WriteLine("Seu número é par!!");
                }
                else if (n1 % 2 == 1)
                {
                    Console.WriteLine("Seu número é ímpar!!");
                }

                Console.Write("Deseja continuar? Digite S/s para sim e N/n para não ");
                resposta = Console.ReadLine();
            } while (resposta != "N" && resposta != "n");
        }
        private static void Idade()
        {
            int anoatual, ano, idade;
            string resposta;

            do
            {

                Console.Clear();
                Console.Write("Qual é o ano atual: ");
                anoatual = int.Parse(Console.ReadLine());

                Console.Write("Qual ano você nasceu: ");
                ano = int.Parse(Console.ReadLine());

                idade = anoatual - ano;

                if (idade >= 0 && idade <= 3)
                {
                    Console.WriteLine("Você tem " + idade + " anos e é um bebê.");
                }
                else if (idade >= 3 && idade <= 9)
                {
                    Console.WriteLine("Você tem " + idade + " anos e é uma criança.");

                }
                else if (idade >= 10 && idade <= 13)
                {
                    Console.WriteLine("Você tem " + idade + " anos e é um pré-adolescente.");
                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("Você tem " + idade + " anos e é um adolescente.");
                }
                else if (idade >= 18 && idade <= 36)
                {
                    Console.WriteLine("Você tem " + idade + " anos e é um jovem.");
                }
                else if (idade >= 37 && idade <= 59)
                {
                    Console.WriteLine("Você tem " + idade + " anos e é um adulto.");
                }
                else if (idade >= 60)
                {
                    Console.WriteLine("Você tem " + idade + " anos e é um idoso.");
                }
                Console.Write("Deseja continuar? Digite S/s para sim e N/n para não ");
                resposta = Console.ReadLine();
            } while (resposta != "N" && resposta != "n");
        }
        private static void Corre_palavra()
        {
            string vPalavra, resposta;
            int x, y, n;

            do
            {

                Console.Clear();
                Console.Write("Digite uma frase ou uma palavra: ");
                vPalavra = Console.ReadLine();
                Console.Write("Quantas Vezes? ");
                n = int.Parse(Console.ReadLine());

                for (y = 1; y <= n; y++)
                {
                    for (x = 0; x <= 79; x++)
                    {
                        Console.SetCursorPosition(x, y + 12);
                        Console.Write(vPalavra);
                        Thread.Sleep(50);
                        Console.SetCursorPosition(x, y + 12);
                        Console.Write(new string(' ', vPalavra.Length));
                    }
                }
                Console.SetCursorPosition(30, 22);
                Console.Write("Deseja continuar? Digite S/s para sim e N/n para não ");
                resposta = Console.ReadLine();
            } while (resposta != "N" && resposta != "n");
        }

        private static void Média()
        {
            int n1, n2, n3, n4, media;
            string resposta;
            do
            {

                Console.Clear();
                Console.WriteLine("Digite a primeira nota:");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota:");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a terceira nota:");
                n3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quarta nota:");
                n4 = int.Parse(Console.ReadLine());
                media = (n1 + n2 + n3 + n4) / 4;
                Console.WriteLine("A sua média é");
                Console.WriteLine(media);

                if (media <= 5)
                {
                    Console.WriteLine("Você esta insatisfatório.");
                }
                else if (media <= 7.5)
                {
                    Console.WriteLine("Você esta regular.");

                }
                else if (media <= 9.5)
                {
                    Console.WriteLine("Você esta bom.");

                }

                else
                {
                    Console.WriteLine("Você esta muito bom.");

                }
                Console.Write("Deseja continuar? Digite S/s para sim e N/n para não ");
                resposta = Console.ReadLine();
            } while (resposta != "N" && resposta != "n");
        }

        private static void Vogais_e_Consoantes()
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

        private static void Mês_ou_Dia()
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

        private static void Analise_Números()
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

        private static void Estado_e_Sigla()
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
        private static void Número_Aleatório()
        {
            Random aleatorio = new Random();
            int N, P;
            string vResp;

            do
            {
                Console.Clear();
                Console.Write("Digite um número:");
                P = int.Parse(Console.ReadLine());
                N = aleatorio.Next(0, 6);
                Console.WriteLine("O número gerado foi " + N);
                N = aleatorio.Next(0, 6);
                Console.WriteLine("O segundo número gerado foi " + N);

                if (P == N)
                {
                    Console.WriteLine("Você acertou!");
                }

                else if (P != N)
                {
                    Console.WriteLine("Você errou!");
                    Console.Write("Digite outro número: ");
                    P = int.Parse(Console.ReadLine());
                    N = aleatorio.Next(0, 6);
                    Console.WriteLine("O número gerado foi " + N);
                    N = aleatorio.Next(0, 6);
                    Console.WriteLine("O segundo número gerado foi " + N);
                    Console.WriteLine("Você errou de novo");

                    Console.Write("Digite outro número: ");
                    P = int.Parse(Console.ReadLine());
                    N = aleatorio.Next(0, 6);
                    Console.WriteLine("O número gerado foi " + N);
                    N = aleatorio.Next(0, 6);
                    Console.WriteLine("O segundo número gerado foi " + N);
                    Console.WriteLine("Você errou mais uma vez");
                }

                Console.WriteLine("Deseja continuar? (S/N)");
                vResp = Console.ReadLine();
            } while (vResp != "N" && vResp != "n");
        }

        private static void Número_Extenso_0_1000()
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

        private static void Fim()
        {
            Console.SetCursorPosition(26, 22);
            Console.Write("!!**Você Chegou ao Fim**!!");
            Console.ReadKey();
        }

        static void janela(int C1, int L1, int C2, int L2)
        {
            int x;
            for (x = L1; x <= L2; x++)
            {
                Console.SetCursorPosition(C1, x);
                Console.Write("║");//ALt + 186 Teclado Numérico
                Console.SetCursorPosition(C2, x);
                Console.Write("║");
            }
            for (x = C1; x <= C2; x++)
            {
                Console.SetCursorPosition(x, L1);
                Console.Write("═"); // Alt + 205 Teclado númérico
                Console.SetCursorPosition(x, L2);
                Console.Write("═"); // Alt + 205 Teclado númérico
            }
            //Vértices
            Console.SetCursorPosition(C1, L1);
            Console.Write("╔"); // Alt + 201 Teclado númérico
            Console.SetCursorPosition(C2, L1);
            Console.Write("╗"); //Alt + 201 Teclado numérico
            Console.SetCursorPosition(C1, L2);
            Console.Write("╚"); //ALt + 200 Teclado numérico
            Console.SetCursorPosition(C2, L2);
            Console.Write("╝");//ALt + 188 Teclado numérico
        }
        static void janela2(int C1, int L1, int C2, int L2)
        {
            int x;
            for (x = L1; x <= L2; x++)
            {
                Console.SetCursorPosition(C1, x);
                Console.Write("║");//ALt + 186 Teclado Numérico
                Console.SetCursorPosition(C2, x);
                Console.Write("║");
            }
            for (x = C1; x <= C2; x++)
            {
                Console.SetCursorPosition(x, L1);
                Console.Write("═"); // Alt + 205 Teclado númérico
                Console.SetCursorPosition(x, L2);
                Console.Write("═"); // Alt + 205 Teclado númérico
            }
            //Vértices
            Console.SetCursorPosition(C1, L1);
            Console.Write("╔"); // Alt + 201 Teclado númérico
            Console.SetCursorPosition(C2, L1);
            Console.Write("╗"); //Alt + 201 Teclado numérico
            Console.SetCursorPosition(C1, L2);
            Console.Write("╚"); //ALt + 200 Teclado numérico
            Console.SetCursorPosition(C2, L2);
            Console.Write("╝");//ALt + 188 Teclado numérico
        }
        static void janela3(int C1, int L1, int C2, int L2)
        {
            int x;
            for (x = L1; x <= L2; x++)
            {
                Console.SetCursorPosition(C1, x);
                Console.Write("║");//ALt + 186 Teclado Numérico
                Console.SetCursorPosition(C2, x);
                Console.Write("║");
            }
            for (x = C1; x <= C2; x++)
            {
                Console.SetCursorPosition(x, L1);
                Console.Write("═"); // Alt + 205 Teclado númérico
                Console.SetCursorPosition(x, L2);
                Console.Write("═"); // Alt + 205 Teclado númérico
            }
            //Vértices
            Console.SetCursorPosition(C1, L1);
            Console.Write("╔"); // Alt + 201 Teclado númérico
            Console.SetCursorPosition(C2, L1);
            Console.Write("╗"); //Alt + 201 Teclado numérico
            Console.SetCursorPosition(C1, L2);
            Console.Write("╚"); //ALt + 200 Teclado numérico
            Console.SetCursorPosition(C2, L2);
            Console.Write("╝");//ALt + 188 Teclado numérico
        }

    }
}