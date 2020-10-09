using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\Users\miguel\Desktop\conversa.txt"; 
            string targetpath = @"C:\Users\miguel\Desktop\conversa.txt";

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
            Console.ReadKey();
        }
    }
}
