using System;
using System.IO;

namespace IOExceptionFileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\webde\Desktop\Teste.txt"; // @ - Uma barra no caminho diretorio
            string targetPath1 = @"C:\Users\webde\Desktop\Copia1.txt";
            string targetPath2 = @"C:\Users\webde\Desktop\Copia2.txt";

            try
            {   // Com File 
                File.Copy(sourcePath, targetPath1); // Cria copia Teste1

                // Com obj FileInfo 
                FileInfo fileInfo = new FileInfo(sourcePath); // Cria copia Teste2
                fileInfo.CopyTo(targetPath2);

                // Mostra no console
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
