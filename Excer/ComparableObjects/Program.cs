using ComparableObjects.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace ComparableObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Usuario\caminho\caminho\TextFile1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort(); // usa IComparable. Um obj deve implementar IComparable. Employee Implementa
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}