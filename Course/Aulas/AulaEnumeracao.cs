using C__Seção8.Entities;
using C__Seção8.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    /* Na aula fazemos a conversão de string para enumeração assim:

    OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
    Mas, dependendo da versão do compilador C#, isso pode dar problema. Se for o caso, por favor tente deste jeito:

    OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
    Se mesmo assim ainda tiver dando erro, há ainda uma terceira forma:

    OrderStatus os;
    Enum.TryParse("Delivered", out os); */
    internal class AulaEnumeracao
    {
        public static void Aula()
        {
            Order order = new Order
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);

            Console.WriteLine(txt);
        }
    }
}
