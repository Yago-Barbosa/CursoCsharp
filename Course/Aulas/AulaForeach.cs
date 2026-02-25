using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaForeach
    {
        public static void Aula()
        {
            string[] vect = new string[] { "Maria" , "Alex", "Bob"};

            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("-------------------------");

            // Para cada string de "nome"(ou apelido qualquer) no vetor, será escrito um "nome"
            foreach (string nome in vect)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
