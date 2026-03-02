using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Course.Entities;

namespace Course.Atividades
{
    internal class AtvProdutos
    {
        // Exercicio de fixação Aula 116
        public static void Exercicio() {
            Console.Write("Enter the Number of products: ");
            int n = int.Parse(Console.ReadLine()!);

            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char opt = char.Parse(Console.ReadLine()!);
                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                if (opt == 'c' || opt == 'C')
                {
                    products.Add(new Product(name, price));
                } else if(opt == 'i' || opt == 'i'){
                    Console.Write("Custom Fee: ");
                    double customFee = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customFee));
                } else if(opt == 'u' || opt == 'U'){
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateOnly manufactureDate = DateOnly.Parse(Console.ReadLine()!);
                    products.Add(new UsedProduct(name, price, manufactureDate));
                } else {
                    Console.WriteLine("Invalid Option");
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
