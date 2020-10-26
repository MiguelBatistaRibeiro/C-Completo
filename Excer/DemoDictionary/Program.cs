using System;
using System.Collections.Generic;

namespace DemoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122"; 
            cookies["phone"] = "99771133"; // novo valor key

            Console.WriteLine(cookies["email"]);
            cookies.Remove("email");

            Console.WriteLine("Número telefone: " + cookies["phone"]);
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("Não há chave 'email'");
            }

            Console.WriteLine("Tamanho: " + cookies.Count);
            Console.WriteLine("TOTAL COOKIES:");

            foreach (KeyValuePair<string, string> item in cookies) // ou var
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            Console.ReadLine();
        }
    }
}
