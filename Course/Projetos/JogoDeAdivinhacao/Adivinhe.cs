using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Projetos.JogoDeAdivinhacao
{
    internal class Adivinhe
    {
        public static void Jogo()
        {
            // Projeto básico, jogo de adivinhação, 5 tentativas máximas para acertar um valor de 0 - 10

            Random random = new Random();
            int numSecreto = random.Next(0, 11);
            int tentativas = 5;
            Console.WriteLine("============ Jogo de Adivinhação ============");
            Console.WriteLine();
            Console.WriteLine("Tente Adivinhar o número escolhido (0 - 10)");

            for (int i = 1; i <= tentativas; i++)
            {
                Console.Write($"{i}# Tentativa: ");
                int numEscolhido = int.Parse(Console.ReadLine()!);
                if (numEscolhido == numSecreto)
                {
                    Console.WriteLine("Parábens, você acertou o número secreto!!!");
                    return;
                }
                else if (numEscolhido > numSecreto && numEscolhido <= 10)
                {
                    Console.WriteLine("O número secreto é menor...");
                }
                else if (numEscolhido < numSecreto && numEscolhido <= 10)
                {
                    Console.WriteLine("O número secreto é maior...");
                }
                else
                {
                    // caso ele escolha um número maior que dez suas tentativas não se esgostarão
                    Console.WriteLine("O número secreto está entre 0 e 10...");
                    i--;
                }

                Console.WriteLine();
            }
            Console.WriteLine("Que pena, não foi dessa vez...");
            Console.WriteLine();
            Console.WriteLine($"O número secreto era {numSecreto}");
        }
    }
}
