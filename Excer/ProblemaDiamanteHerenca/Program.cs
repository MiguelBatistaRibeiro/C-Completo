using ProblemaDiamanteHerenca.Entities;
using System;

namespace ProblemaDiamanteHerenca
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("Minha carta");
            p.Print("Minha carta");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("Meu email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("Meu resumo");
            c.Print("Meu resumo");

            Console.ReadLine();
        }
    }
}
