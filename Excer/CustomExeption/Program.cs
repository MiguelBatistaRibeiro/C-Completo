using CustomExeption.Entities;
using System;

namespace CustomExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero do Quarto: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Data Entrada (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Data Saída (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            DateTime now = DateTime.Now; 
            if (checkIn < now || checkOut < now) 
            {
                Console.WriteLine("Erro: Data Inferior a Data ATUAL");
            }
            else if (checkOut <= checkIn)
            {
                Console.WriteLine("Erro: Data de Saída menor que Entrada");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Entre com a data de atualização da reserva");
                Console.WriteLine("Data Entrada (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Data Saída (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                if(checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Erro: Data Inferior a Data ATUAL");
                } 
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Erro: Data de Saída menor que Entrada");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reserva: " + reservation);
                }
            }
            Console.ReadLine();
        }
    }
}
