using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaPath
    {
        public static void Exemplo()
        {
            string path = @"c:\temp\myfolder\file1.txt";

            // Path realiza operações com strings que contém informações de arquivos ou pastas...

            // Pega o caractere que separa o caminho das pastas (no caso do windows \ )
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            // Pega o caractere separador ( ; )
            Console.WriteLine("PathSeparator : " + Path.PathSeparator);
            // Pega a "porção" da pasta em que o arquivo está
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            // Pega o nome do arquivo, nome do arquivo sem extensão e a extensão do arquivo respectivamente...
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            // Pega o caminho completo
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            // Informa a pasta temporária do sistema, na qual dados de aplicação podem ser manipulados
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
