using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    public class Atv3
    {
        public static void Exercicio()
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("--------- Dados da Primeira Pessoa ------------ ");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("--------- Dados da Segunda Pessoa ----------");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.Idade = int.Parse(Console.ReadLine());

            if (a.Idade > b.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
            } else if(b.Idade > a.Idade){
                Console.WriteLine("Pessoa mais velha: " + b.Nome);
            } else {
                Console.WriteLine("As duas pessoas possuem a mesma idade");
            }
        }
    }
}
