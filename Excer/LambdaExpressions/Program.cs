using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fibNumbers = new List<int> { 4, 1, 5, 18, 9, 5, 8, 13 };
            int count = 0;
            foreach (int element in fibNumbers)
            {
                count = count + 1;
                Console.WriteLine($"Elemento #{count}: {element}");
            }
            Console.WriteLine($"Numero de elementos: {count}");
            
            Console.WriteLine("---------------------------------------------");
            
            List<string> list = new List<string>() { "Miguel", "Pedro" };
            
            list.Add("Maria");
            list.Add("Altonio");
            list.Add("Alfredo");
            list.Add("Alfranio");

            list.Insert(0, "Anna"); // INSERE NO LIST E EMPURRA OS DEMAIS
            list.Remove("Miguel");  // REMOVE DOO LIST

            Console.WriteLine($"LIST COM ESPAÇO PARA {list.Count} NOMES");
            Console.WriteLine();
            
            string s1 = list.Find(x => x[0] == 'A'); 
            Console.WriteLine($"Primeiro elemento do list com 'A' é: {s1}");

            string s2 = list.FindLast(x => x[0] == 'A'); 
            Console.WriteLine($"Ultimo elemento do list com 'A' é: {s2}");

            int pos1 = list.FindIndex(x => x[0] == 'A'); 
            Console.WriteLine($"O indice do primeiro elemento que começa 'A' é: {pos1}");

            int post2 = list.FindLastIndex(x => x[0] == 'A'); 
            Console.WriteLine($"O indice do ultimo elemento que começa com 'A' é: {post2}");

            Console.WriteLine("---------------------------------------------");

            // RemoveAt, RemoveAll e RemoveRange

            // list.RemoveAt(1); // REMOVE PELO INDICE > PEDRO
            // list.RemoveAll(x => x[2] == 'f'); // REMOVE TODOS 3 LETRA == 't' > ALTONIO
            // list.RemoveRange(1, 2); // REMOVE A PARTIR DO INDICE 1, 2 ELEMENTOS

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------Filtrando-----------------");

            List<string> list2 = list.FindAll(x => x.Length == 7);

            foreach(string item in list2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        //Como seria sem o lambdaExpressions
        
        // string encontra = list.Find(Test);
        //static bool Test(string s)
        //{
        //    return s[0] == 'A';
        //}
    }
}
