using System;

namespace ProblemaDiamanteHerenca.Entities
{
    // Caso as classes Scanner e Printer fossem herdadas por ComboDevice, iria gerar ambiguidade, 
    // uma vez que ambas possuem o método ProcessDoc() de Device.
    // Correção > ComboDevice herda Device + métodos interfaces com polimorfismo
    class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Processando Dispositivo Combo: " + document);
        }
        public void Print(string document)
        {
            Console.WriteLine("Impressão Dispositivo Combo: " + document);
        }
        public string Scan()
        {
            return "Dispositivo escaneando resultado";
        }
    }
}
