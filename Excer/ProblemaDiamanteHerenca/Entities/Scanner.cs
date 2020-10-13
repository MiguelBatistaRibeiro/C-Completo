using System;

namespace ProblemaDiamanteHerenca
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Escanear: " + document);
        }
        public string Scan()
        {
            return "Resultado da verificação";
        }
    }
}
