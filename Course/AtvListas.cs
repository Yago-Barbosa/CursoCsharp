using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    internal class AtvListas
    {
        public static void Exercicio()
        {
            List<Employee> ids = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine()!);
                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                ids.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int idIncrease = int.Parse(Console.ReadLine()!);

            Employee? emp = ids.Find(x => x.ID == idIncrease);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            } else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee ID in ids)
            {
                Console.WriteLine(ID);
            }
        }
    }
}
