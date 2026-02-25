using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaMatrizes
    {
        public static void Aula()
        {

            //tipo de matriz, [,] , nome e se necessario sua inicialização  
            double[,] mat = new double[2, 3];

            // Length diz quantos elementos a matriz tem no total
            Console.WriteLine(mat.Length);

            // Rank diz quanto é a primeira dimensão da matriz (quantidade de linhas)
            Console.WriteLine(mat.Rank);

            // GetLength pode se especifcar em qual dimensão deseja visualizar seu tamanho(Linhas)
            Console.WriteLine(mat.GetLength(0));

            // Colunas
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
