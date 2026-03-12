using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaTryCatch
    {
        public static void ExPratico()
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException error)
            {
                Console.WriteLine("Format error! " + error.Message);
            }
        }
    }
}
