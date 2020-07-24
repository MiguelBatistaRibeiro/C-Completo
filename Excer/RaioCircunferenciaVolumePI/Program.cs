using System;
using System.Globalization;


// Programa que obtem o raio de um círculo e calcula circunferência e volume
namespace RaioCircunferenciaVolumePI
{
    public class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio: ");
            var valorRaio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(valorRaio);
            double volume = Volume(valorRaio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Volume: " + volume.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("PI:  = " + circ.ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadKey();
        }
        // Quando uma funçao static exige outra, também deve ser static
        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }
        // sem necessidade de public, acessivel apenas para esta class
        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }
    }
}
