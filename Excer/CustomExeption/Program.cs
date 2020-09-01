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

            if (checkOut <= checkIn)
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

                string error = reservation.UpdateDates(checkIn, checkOut);
                
                if(error != null)
                {
                    Console.WriteLine("Erro na reserva: " + error);
                }
                else
                {
                    Console.WriteLine("Reserva: " + reservation);
                }
            }
            Console.ReadLine();
        }
    }
}
