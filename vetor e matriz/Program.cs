using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            bool continua = true;
            do
            {
                Console.WriteLine("\tMENU EXERCÍCIOS");
                Console.WriteLine("1- SOMAR ELEMENTOS DO VETOR ");
                Console.WriteLine("2- MÉDIA ELEMENTOS DO VETOR");
                Console.WriteLine("3- MAIOR ELEMENTO ENTRE 2 VETORES");
                Console.WriteLine("4- PERCORRER VETOR COMEÇANDO DO ÚLTIMO ELEMENTO");
                Console.WriteLine("5- MAIOR NÚMERO DA MATRIZ");
                Console.WriteLine("6- NÚMEROS PARES DA MATRIZ");
                Console.WriteLine("7- SOMA DE VALORES DA LINHA QUE É MAIOR NA MATRIZ");
                Console.WriteLine("8- MÉDIA DAS COLUNAS NA ÚLTIMA LINHA DA MATRIZ");
                Console.Write("\nEscolha o exercício: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: ex01(); break;
                    case 2: ex02(); break;
                    case 3: ex03(); break;
                    case 4: ex04(); break;
                    case 5: ex05(); break;
                    case 6: ex06(); break;
                    case 7: ex07(); break;
                    case 8: ex08(); break;

                    default: Console.WriteLine("Opção inválida"); break;
                }
            } while (continua == true);
        }

        static void ex01()
        {
            Console.WriteLine("\n\tEXERCÍCIO 1");

            int[] array = new int[5];
            int soma = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\nDigite cinco números: ");
                array[i] = int.Parse(Console.ReadLine());
                soma = soma + array[i];
            }

            Console.WriteLine($"\nA soma é dos números do vetor é: {soma}");
            Console.ReadKey();
        }

        static void ex02()
        {
            Console.WriteLine("\n\tEXERCÍCIO 2");

            int[] array = new int[5];
            int soma = 0;
            double media = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\nDigite cinco números: ");
                array[i] = int.Parse(Console.ReadLine());
                soma = soma + array[i];
                media = soma / 5;
            }

            Console.WriteLine($"\nA média dos números do vetor é: {media}");
            Console.ReadKey();
        }

        static void ex03()
        {
            Console.WriteLine("\n\tEXERCÍCIO 3");

            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int maior = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\nDigite cinco números para o primeiro vetor: ");
                array1[i] = int.Parse(Console.ReadLine());
                if (array1[i] > maior)
                {
                    maior = array1[i];
                } else { }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\nDigite cinco números para o segundo vetor: ");
                array2[i] = int.Parse(Console.ReadLine());
                if (array2[i] > maior)
                {
                    maior = array2[i];
                } else { }
            }

            Console.WriteLine($"\nO maior elemento entre dois vetores é: {maior}");
            Console.ReadKey();
        }

        static void ex04()
        {
            Console.WriteLine("\n\tEXERCÍCIO 4");

            int[] array = new int[5];

            for (int i = 4; i >= 0; i--)
            {
                Console.Write("\nDigite cinco números: ");
                array[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"{array[i]}");
            }

            Console.ReadKey();
        }

        static void ex05()
        {
            Console.WriteLine("\n\tEXERCÍCIO 5");

            int[,] matriz = new int[5, 5];
            int maior = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("\nDigite cinco números: ");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                    if (matriz[i,j] > maior)
                    {
                        maior = matriz[i, j];
                    } else { }
                }
            }

            Console.WriteLine($"\nO maior elemento entre dois vetores é: {maior}");
            Console.ReadKey();
        }

        static void ex06()
        {
            Console.WriteLine("\n\tEXERCÍCIO 6");

            int[,] matriz = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("\nDigite cinco números: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (matriz[i, j] % 2 == 0)
                    {
                        Console.WriteLine($"\nOs números pares da matriz são: {matriz[i,j]}");
                    }
                    else { }
                }
            }

            Console.ReadKey();
        }

        static void ex07()
        {
            Console.WriteLine("\n\tEXERCÍCIO 7");

            int[,] matriz = new int[5, 5];
            int soma = 0;
            int maior = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("\nDigite cinco números: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    soma = soma + matriz[i, j];
                }
                if (soma > maior)
                {
                    maior = soma;
                }
                else { }
            }

            Console.WriteLine($"\nA soma de valores da linha que é maior na matriz é: {soma}");
            Console.ReadKey();
        }

        static void ex08()
        {
            Console.WriteLine("\n\tEXERCÍCIO 8");

            int[,] matriz = new int[5, 5];
            int soma = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("\nDigite cinco números: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (i < 4)
                    {
                        soma = matriz[i, j] + soma;
                    }
                    else 
                    {
                        matriz[i, j] = soma/4;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}