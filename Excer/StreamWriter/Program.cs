using System;
using System.IO;

namespace streamWriter
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Program que copia escrita de um arquivo para outro em UpperCase
            string sourcepath = @"C:\Users\webde\Desktop\Teste.txt";
            string targetpath = @"C:\Users\webde\Desktop\Teste2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}
