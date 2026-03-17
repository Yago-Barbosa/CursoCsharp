using System;
using System.Globalization;

namespace Course.Projetos.ProjetoCalculadora
{
    internal class Calculadora
    {
        public static void Calc()
        {
            try {
                Console.WriteLine("========= Calculator =========");
                Console.WriteLine();
                Console.Write("Enter the first number: ");
                double n1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                Console.Write("Enter the operator (+ - * /): ");
                char oprt = char.Parse(Console.ReadLine()!);
                Console.Write("Enter the second number: ");
                double n2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                double result = 0;

                Console.WriteLine($"Number typed: {n1} {oprt} {n2}");

                switch (oprt)
                    {
                    case '+':
                        result = n1 + n2;
                        break;
                    case '-':
                        result = n1 - n2;
                        break;
                    case '*':
                        result = n1 * n2;
                        break;
                    case '/':                        
                        result = n1 / n2;
                        break;
                    default:
                        Console.WriteLine("Invalid Operator");
                        break;
                    }
          
                Console.WriteLine("Result: " + result.ToString(),CultureInfo.InvariantCulture);
            }
            catch (FormatException error)
            {
                Console.WriteLine("Format error: " + error.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine("Unexpected error: " + error.Message);
            }
        }

        public static void Teste()
        {
            Console.WriteLine("========= Calculator =========");
            Console.WriteLine();
            Console.WriteLine("1) Sum");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");
            Console.WriteLine();

            Console.Write("Choose your operation: ");
            int opt = int.Parse(Console.ReadLine()!);

            Console.WriteLine();
            Console.Write("Enter the first number: ");
            double n1 = double.Parse(Console.ReadLine()!);
            Console.Write("Enter the second number: ");
            double n2 = double.Parse(Console.ReadLine()!);
            Calculator calc = new Calculator(opt);
            double result = 0;

            switch (opt) { 
                case 1:
                    result = calc.Sum(n1, n2);
                    break;
                case 2:
                    result = calc.Subtract(n1, n2);
                    break;
                case 3:
                    result = calc.Multiply(n1, n2);
                    break;
                case 4:
                    result = calc.Divide(n1, n2);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
                }

            if(result != 0)
            {
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
