using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Course.Entities;

namespace Course.Atividades
{
    internal class AtvFiles
    {
        public static void Exercicio()
        {
            string path = @"c:\temp\AtvC#\products.csv";
            string targetPath = @"c:\temp\AtvC#\out\summary.csv";

            try
            {
                string[] lines = File.ReadAllLines(path);
                Directory.CreateDirectory(@"c:\temp\AtvC#\out");

                // Append = Concatena(adiciona) no final do arquivo
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Produto prod = new Produto(name, price, quantity);
                        sw.WriteLine(prod.Nome + ", " + prod.ValorTotal().ToString("f2",CultureInfo.InvariantCulture));
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
