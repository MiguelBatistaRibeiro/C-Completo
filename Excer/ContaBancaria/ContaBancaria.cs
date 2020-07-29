using System.Globalization;

namespace ContaBancaria
{
    public class ContaBancaria 
    {
        public int Numero { get; private set; }      // PODE SER ACESSADO, MAS NÃO ALTERADO
        public string Titular { get; set; }
        public double Saldo { get; private set; }    // PODE SER ACESSADO, MAS NÃO ALTERADO
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial); 
            // Saldo = depositoInicial;
        }
        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5;
            //Saldo -= 5.0;
        }
        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
