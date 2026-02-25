using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course.Aulas
{
    internal class AulaConcatenacao
    {
        static void Test(string[] args)
        {
            int idade = 32;
            double saldo = 10.24497243443;
            string nome = "Yago";

            //====================== PlaceHolders =============================

            Console.WriteLine("{0} tem {1} anos e tem saldo {2:F4} reais", nome, idade, saldo);

            //====================== Interpolação =============================

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo {saldo:F4} reais");

            //====================== Concatenação =============================
            // Só é possivel trocar as pontuaçoes para o padrão com o Globalization nesse
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo " + saldo.ToString("F4", System.Globalization.CultureInfo.InvariantCulture) + " reais ");
        }
    }
}
