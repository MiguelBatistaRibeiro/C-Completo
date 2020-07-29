using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOVO OBJ
            ContaBancaria conta;

            Console.WriteLine("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome do titular: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá deposito inicial (s / n)? ");
            char resp = char.Parse(Console.ReadLine());

            // ASPAS SIMPLES PARA CHAR - UM CARACTER
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre com o valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta); 

            Console.WriteLine();
            Console.WriteLine("Entre com o valor de deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.ReadKey();
        }
    }
}
