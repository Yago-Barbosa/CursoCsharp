using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Atividades
{
    internal class AtvMatriz
    {
        public static void Exercicio()
        {
            Console.Write("Digite o número de linhas: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Digite o número de colunas: ");
            int m = int.Parse(Console.ReadLine()!);

            int[,] mat = new int[n, m];

            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine()!.Split(' ');

                for(int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Digite um número que está na matriz: ");
            int num = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }

                        if (i < n - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
