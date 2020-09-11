using System;
using System.IO;

namespace FileStremStremReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\webde\Desktop\Teste.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ocorreu");
                Console.WriteLine(e.Message);
            } 
            finally
            {
                if (sr != null) sr.Close();
            }
            Console.ReadLine(); 
        }
    }
}
