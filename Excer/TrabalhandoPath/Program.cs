using System;
using System.IO;

namespace TrabalhandoPath
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\user\Desktop\arquivo.txt";

            Console.WriteLine("Caracter separação de pastas: " + Path.DirectorySeparatorChar);
            Console.WriteLine("Caracter separação de paths: " + Path.PathSeparator);
            Console.WriteLine("Caminho do arquivo: " + Path.GetDirectoryName(path));
            Console.WriteLine("Arquivo - com extensão: " + Path.GetFileName(path));
            Console.WriteLine("Extensão do arquivo: " + Path.GetExtension(path));
            Console.WriteLine("Arquivo - sem extensão: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Caminho completo: " + Path.GetFullPath(path));
            Console.WriteLine();
            Console.WriteLine("Caminho arquivos temporários do sistema: ");
            Console.Write(Path.GetTempPath());

            Console.ReadLine();
        }
    }
}
