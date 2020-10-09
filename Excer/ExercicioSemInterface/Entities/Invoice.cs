using System.Globalization;

namespace ExercicioSemInterface.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Pagamento Básico: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento Total: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
