using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaFiles
    {
        public static void BlockUsing()
        {

            string path = @"c:\temp\file1.txt";

            // Ao usar esse bloco todos os recursos instanciados nele serão fechados ao final da execução
            // Também é possivel "cascatear" esse bloco
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }

        public static void PraticaFileStream()
        {
            string path = @"c:\temp\file1.txt";

            // FileStream fs = null;
            StreamReader sr = null;

            try
            {
                // fs = new FileStream(path, FileMode.Open);
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine()!;
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                // O filestream e streamreader são recursos externos e devem ser fechados (maneira manual)
                if (sr != null) sr.Close();
                // if( fs != null ) fs.Close();
            }
        }

        public static void PraticaFile()
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
