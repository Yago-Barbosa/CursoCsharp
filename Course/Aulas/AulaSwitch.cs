using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaSwitch
    {
        public static void Aula()
        {
            // Sintaxe opcional quando há vários if-elses enquadeados, quando a condição envolve o teste do valor de uma variavel

            int x = int.Parse(Console.ReadLine());

            string day;

            switch (x){
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid Value";
                    break;
                }

            Console.WriteLine("Day : " + day);
        }
    }
}
