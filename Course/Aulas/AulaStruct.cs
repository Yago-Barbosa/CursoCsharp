namespace Course.Aulas
{
    public class AulaStruct
    {
        public static void Aula()
        {
            // Mesmo sendo um Tipo Struct tambem é preciso inicializar
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            // Sem ser necessario o new Point
            p = new Point();
            Console.WriteLine(p);
        }
    }
}
