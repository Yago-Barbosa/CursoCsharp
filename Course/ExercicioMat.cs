using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    internal class ExercicioMat
    {
        public static void Exercicio() {

            Console.Write("Quantas linhas e colunas a matriz terá? ");
            int n = int.Parse(Console.ReadLine()!);

            int[,] mat = new int[n, n];
            int negativeNumbers = 0;

            // O primeiro for conta as linhas
            for (int i = 0; i < n; i++)
            {
                // Recebe 3 valores que são divididos com o split
                // Console.WriteLine((i + 1) + "# Linha");
                string[] value = Console.ReadLine()!.Split(' ');

                // O segundo for conta as colunas
                for(int j = 0; j < n; j++) 
                {
                    // Cada um dos tres valores vai pra uma coluna
                    mat[i, j] = int.Parse(value[j]);
                    // E depois isso se repete para outra linha, até que a matriz fique completa 
                }
            }

            Console.WriteLine();
            Console.WriteLine("Main Diagonal");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            // Usar dois "for" é a estrutura basica para percorrer matrizes
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++)
                {
                    if(mat[i, j] < 0)
                    {
                        negativeNumbers += 1;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Negative Numbers: " + negativeNumbers);
        }
    }
}
