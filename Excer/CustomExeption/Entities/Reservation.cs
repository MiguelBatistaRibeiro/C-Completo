using CustomExeption.Entities.Exceptions;
using System;

namespace CustomExeption.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Reservation()
        {

        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Data de Saída menor que Entrada");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration() 
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays; 
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                 throw new DomainException ("Data Inferior a Data ATUAL"); // lançar exception
            }
            if (checkOut <= checkIn)
            {
                 throw new DomainException ("Data de Saída menor que Entrada");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public override string ToString()
        {
            return "Quarto "
            + RoomNumber
            + ", Entrada: "
            + CheckIn.ToString("dd/MM/yyyy")
            + ", Saída: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " Noites";
        }
    }
}
