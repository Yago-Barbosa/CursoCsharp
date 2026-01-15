using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    internal class Atv1
    {
        static void Lesson(string[] args) // Trocar para Main caso eu queria executar
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            // ================ Saida ===================

            Console.WriteLine($"{produto1}, cujo preço é ${preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é &{preco2:F2}");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"Medida com oito casa decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
