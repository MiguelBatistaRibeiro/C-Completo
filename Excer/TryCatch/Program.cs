using System;
using System.IO;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException) // se dividir por zero
            {
                Console.WriteLine("Divisão por zero não é permitida");
            }
            catch (FormatException e) // se digitar letra
            {
                Console.WriteLine("Erro de Formato! " + e.Message);
            }

            // Exemplo ao abrir arquivo inexistente
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
