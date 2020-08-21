using Enumeracao.Entities;
using Enumeracao.Entities.Enums;
using System;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 15,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            // converte enum para string - basta chamar o ToString
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine("Enum para String: " + txt);

            // converte string para enum 
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            Console.WriteLine("String para Enum: "+ os);

            Console.ReadLine();
        }
    }
}
