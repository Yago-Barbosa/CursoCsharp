using System;
using System.Collections.Generic;
using System.Text;

namespace Course.JogoDeAdivinhacao
{
    internal class Adivinhe
    {
        public static void Jogo()
        {
            // Projeto básico, jogo de adivinhação, 5 tentativas máximas para acertar um valor de 0 - 10

            Random random = new Random();
            int numSecreto = random.Next(0, 11);
            bool ganhou = false;
            Console.WriteLine("============ Jogo de Adivinhação ============");
            Console.WriteLine();
            Console.WriteLine("Tente Adivinhar o número escolhido (0 - 10)");

            for(int i = 1; i <= 5; i++)
            {
                Console.Write($"{i}# Tentativa: ");
                int numEscolhido = int.Parse(Console.ReadLine()!);
                if(numEscolhido == numSecreto)
                {
                    Console.WriteLine("Parábens, você acertou o número secreto!!!");
                    i = 5;
                    ganhou = true;
                } else if (numEscolhido > numSecreto)
                {
                    Console.WriteLine("O número secreto é menor...");
                } else if (numEscolhido < numSecreto)
                {
                    Console.WriteLine("O número secreto é maior...");
                } else
                {
                    Console.WriteLine("O número secreto está entre 0 e 10...");
                }

                Console.WriteLine();
            }
            if (ganhou == false)
                Console.WriteLine("Que pena, não foi dessa vez...");
        }
    }
}
