using System;

namespace ProblemaDiamanteHerenca
{
    class Printer : Device, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("Impressão: " + document);
        }
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Processa doc: " + document);
        }
    }
}
