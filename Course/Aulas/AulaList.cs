using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaList
    {
        public static void AulaPratica()
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string nome in list)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("List Count: " + list.Count);

            // Aqui é utilizado uma expressão lambda (uma função anonima) que pouparia uma criação de função que faria o seguinte:
            /* static bool Test (string s) {
             *      return s[0] == 'A';
             *  }
             * Que basicamente acha o primeiro nome que comece com A */

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            // Aqui ele retorna a posição na lista e não o nome em si
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            // Aqui é criado um filtro que só recebe nomes que possuem 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------------");
            foreach(string nome in list2)
            {
                Console.WriteLine("Names with 5 characters: " + nome);
            }

            list.Remove("Alex");

            // list.RemoveAt(3);

            // list.RemoveRange(2, 2);
            Console.WriteLine("-----------------------");

            foreach(string nome in list)
            {
                Console.WriteLine(nome);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------------------");
            foreach (string nome in list)
            {
                Console.WriteLine(nome);
            }
        }
        public static void AulaTeorica()
        {
            // Inicialização de uma lista vazia
            // List<tipo> nome = instanciação da lista(opcional) 
            List<string> list = new List<string>();

            // Inicialização já com valores 
            List<string> list2 = new List<string> { "Maria", "Alex" };
        }
    }
}
