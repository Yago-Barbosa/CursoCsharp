using Course.Entities;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Atividades
{
    internal class AtvContribuinte
    {
        public static void Exercicio()
        {
            List<Contribuinte> contribuintes = new List<Contribuinte>(); 
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine()!);
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine()!);
                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                if(ch == 'i' || ch == 'I')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    contribuintes.Add(new PessoaFisica(healthExpenditure, name, anualIncome));
                } else if(ch == 'c' || ch == 'C')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine()!);
                    contribuintes.Add(new PessoaJuridica(numberOfEmployees, name, anualIncome));
                } else
                {
                    Console.WriteLine("Invalid Option");
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach(Contribuinte contribuinte in contribuintes)
            {
                Console.WriteLine(contribuinte.Name + ": $" + contribuinte.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
