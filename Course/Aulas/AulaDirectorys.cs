using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaDirectorys
    {
        public static void Pratica()
        {
            string path = @"c:\temp\myfolder";

            try
            {
                // Listar todas as subpastas
                // var no lugar de IEnumerable<string>
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string folder in folders) {
                    Console.WriteLine(folder);
                }

                // Listar todos os arquivos (pasta e subpastas)
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                // Criar uma pasta (caminho "alvo")
                Directory.CreateDirectory(@"c:\temp\myfolder\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
