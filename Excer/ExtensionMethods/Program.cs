using ExtensionMethods.Extensions;
using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 11, 04, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
            Console.WriteLine();

            String str = "Cortando se maior que 20";
            Console.WriteLine(str.Cut(20));
            Console.ReadLine();
        }
    }
}
