using CustomExeption.Entities;
using CustomExeption.Entities.Exceptions;
using System;

namespace CustomExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Numero do Quarto: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Data Entrada (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Data Saída (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Entre com a data de atualização da reserva");
                Console.WriteLine("Data Entrada (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Data Saída (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reserva: " + reservation);

                Console.ReadLine();
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro no formato: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}

