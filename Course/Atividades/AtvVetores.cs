using Course.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Atividades
{
    internal class AtvVetores
    {
        public static void Exercicio()
        {
            Console.Write("Quantos quartos vão ser alugados?: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Aluguel[] vetor = new Aluguel[10]; 

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine()!;
                Console.Write("Email: ");
                string email = Console.ReadLine()!;
                Console.Write("Quarto(0 a 9): ");
                int quarto = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                vetor [quarto] = new Aluguel { Nome = nome, Email = email , Quarto = quarto};
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            
            for(int i = 0; i < 9; i++){
                if (vetor[i] != null){
                    Console.Write(vetor[i].Quarto + ": " + vetor[i].Nome + ", " + vetor[i].Email);
                    Console.WriteLine();
                }
            }
        }
    }
}
