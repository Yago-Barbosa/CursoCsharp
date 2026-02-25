using System;
using System.Globalization;

namespace Course.Entities
{
    class Aluno
    {   
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }
        //public void Resultado()
        //{
        //    //if (NotaFinal() >= 60.0) {
        //    //    Console.WriteLine("Aprovado");
        //    //} else {
        //    //    Console.WriteLine("Reprovado");
        //    //    Console.WriteLine("Faltaram " + (NotaFinal() - 60.0) + "Pontos");
        //    //}
        //}
    }
}
