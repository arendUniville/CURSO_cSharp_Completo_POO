using System;
using aula124.Entities;
using aula124.Entities.Enums;

namespace aula124
{

    class Program
    {

        static void Main(string[] args) 
        {
        
            Order order = new Order
            {

                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };

            Console.WriteLine(order);


            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);

            Console.WriteLine(os);

        }

    }

}