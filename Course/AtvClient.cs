using C__Seção8.Entities.Enums;
using Course.Entities;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Text;
using C__Seção8.Entities;

namespace Course
{
    internal class AtvClient
    {
        public static void Exercicio()
        {
            Console.WriteLine("Enter Client data: ");
            Console.Write("Name: ");
            string? name = Console.ReadLine()!;
            Console.Write("Email: ");
            string? email = Console.ReadLine()!;
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine()!);
            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()!);
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine()!);
            DateTime moment = DateTime.Now;
            Order order = new Order(moment, status, client);

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine()!;
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine()!);
                
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary:");
            Console.WriteLine("Order Moment: " + moment);
            Console.WriteLine("Order Status: " + status);
            Console.WriteLine(client);
            Console.WriteLine("Order Items: ");
            foreach(OrderItem item in order.Items)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(order);
        }
    }
}
