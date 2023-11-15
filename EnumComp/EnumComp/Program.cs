using EnumComp.Entities;
using EnumComp.Entities.Enums;
using System;
using System.Data;
using System.Globalization;


namespace EnumComp{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Enum -> String
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);


            //String -> Enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }



}
