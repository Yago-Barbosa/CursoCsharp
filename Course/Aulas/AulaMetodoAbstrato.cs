//using Course.Entities;
//using System.Globalization;
//using Course.Entities.Enums;

//namespace Course.Aulas
//{
//    internal class AulaMetodoAbstrato
//    {
//        public static void ExercicioResolvido()
//        {
//            Console.Write("Enter the number of shapes: ");
//            int n = int.Parse(Console.ReadLine()!);

//            List<Shape> shapes = new List<Shape>();
//            for (int i = 1; i <= n; i++)
//            {
//                Console.WriteLine($"Shape #{i} data: ");
//                Console.Write("Rectangle or Circle (r/c)? ");
//                char opt = char.Parse(Console.ReadLine()!);
//                Console.Write("Color (Black/Blue/Red): ");
//                Color color = Enum.Parse<Color>(Console.ReadLine()!);
//                if (opt == 'r' || opt == 'R')
//                {
//                    Console.Write("Width: ");
//                    double width = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
//                    Console.Write("Height: ");
//                    double height = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

//                    //shapes.Add(new Rectangle(width, height, color));
//                } else if (opt == 'c' || opt == 'C'){
//                    Console.Write("Radius: ");
//                    double radius = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

//                    //shapes.Add(new Circle(radius, color));
//                }
//            }

//            Console.WriteLine();
//            Console.WriteLine("Shape areas:");
//            foreach (Shape shape in shapes)
//            {
//                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
//            }
//        }
//    }
//}
