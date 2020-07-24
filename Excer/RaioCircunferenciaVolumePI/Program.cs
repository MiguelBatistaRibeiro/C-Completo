using System;
using System.Globalization;


// Programa que obtem o raio de um círculo e calcula circunferência e volume
namespace RaioCircunferenciaVolumePI
{
    public class Program
    {
      
        static void Main(string[] args)
        {
            // Instancia objeto para acesso aos membros
            var calc = new Calculadora();

            Console.WriteLine("Entre com o valor do raio: ");
            var valorRaio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc. Circunferencia(valorRaio);
            double volume = calc.Volume(valorRaio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Volume: " + volume.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("PI: " + calc.Pi.ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadKey();
        }
        
    }
}
