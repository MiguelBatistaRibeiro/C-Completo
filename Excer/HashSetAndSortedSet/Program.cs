using System;
using System.Collections.Generic;

namespace HashSetAndSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {   // como um list - não garante ordem dos elementos
            HashSet<string> hashSet = new HashSet<string>() { "Celular", "DVD" };

            hashSet.Add("TV");
            hashSet.Add("Nootbook");
            hashSet.Add("Tablet");

            Console.WriteLine(hashSet.Contains("Nootbook"));  // true 
            Console.WriteLine(hashSet.Contains("Computador")); // false

            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }
            ///////////////////////////////////////////////////////////////////
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 1, 3, 5, 7, 9 };

            // union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            c.IntersectWith(b);
            PrintCollection(d);

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            c.ExceptWith(b);
            PrintCollection(e);

            Console.ReadLine();
        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
