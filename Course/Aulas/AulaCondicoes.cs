using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaCondicoes
    {
        static void Conditions(string[] args)
        {
            // ------------- Simples = Só o "if" ----------------
            //int x = 10;
            //Console.WriteLine("Bom dia");
            //if (x > 5){
            //    Console.WriteLine("Boa tarde");
            //}
            //Console.WriteLine("Boa noite");

            // ----------- Composta = "if" e "else" -------------
            //Console.Write("Verificador de Par ou Impar: ");
            //int n1 = int.Parse(Console.ReadLine());

            //if ((n1 % 2) == 0){
            //    Console.WriteLine("Par");
            //}
            //else {
            //    Console.WriteLine("Impar");
            //}

            // ------- Encadeamento = "if" e n "else's" ---------

            Console.Write("Que horas são agora?: ");
            int horas = int.Parse(Console.ReadLine());

            // Se a condição só tiver um comando as {} são opcionais
            if (horas < 12)
                Console.WriteLine("Bom Dia!");
            else if (horas < 18)
                Console.WriteLine("Boa Tarde!");
            else
                Console.WriteLine("Boa Noite!");
        }
    }
}
