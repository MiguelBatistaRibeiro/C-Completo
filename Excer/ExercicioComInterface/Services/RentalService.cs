using ExercicioComInterface.Entities;
using System;

namespace ExercicioComInterface.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        // inversão de controle por meio de injeção de dependencia. Não recebe mais a dependencia de BrazilTaxService
        // recebe objeto instanciado e concede-o
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {

            TimeSpan duration = carRental.Finish.Subtract(carRental.Start); // hra final - hra inicial
            // define valor pagamento pela hora ou dia
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); // Ceilling - arredonda +
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            // gera fatura obtendo basicPayment e adiciona em prop (Invoice - tipo Invoice) de CarRental
            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
