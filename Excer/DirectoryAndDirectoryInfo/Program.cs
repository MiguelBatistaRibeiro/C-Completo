using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que lista arquivos de um determinado diretorio
            string path = @"C:\Users\webde\Desktop\diretorio";

            try
            {
                // Lembrar da inferencia de tipo = detecção automática do tipo que a variável recebe
                // ↓ ou var folders... retorna coleção IEnumerable strings das pastas / *.* to all files . all extensions
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // ← ou .TopDirectoryOnly
                Console.WriteLine("FOLDERS: ");
                foreach (string fo in folders)
                {
                    Console.WriteLine(fo);
                } 
                // Listar todos os arquivos de um diretorio ou subdiretorio
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // ← ou .TopDirectoryOnly
                Console.WriteLine("FILES: ");
                foreach (string fi in files)
                {
                    Console.WriteLine(fi);
                }
                // Cria nova pasta
                Directory.CreateDirectory(path + @"\PastaNova");
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu erro");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
