using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    public class AtvAluno
    {
        public static void Exercicio()
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do Aluno: ");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.NotaFinal() >= 60.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + (60.0 - aluno.NotaFinal()).ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
            }
        }
    }
}
