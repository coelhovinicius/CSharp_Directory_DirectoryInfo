/* Directory e DirectoryInfo - Classes para fornecer operacoes com pastas (criar, listar, etc.). Seguem a mesma linha de
   File e FileInfo. 

     - Directory - Operacoes Estaticas;
     - DirectoryInfo - Operacoes de Instancia. 
*/

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using System.IO;
// using System.Collections.Generic;

namespace Aula190_Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\MyFolder";

            try
            {
                // Enumera as Subpastas de MyFolder
                // IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // Sintaxe  Alternativa
                Console.WriteLine("Folders:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine();

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // Enumera os arquivos
                Console.WriteLine("Files:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder"); // Cria uma pasta dentro de MyFolder
            }
            catch(IOException e)
            {
                Console.WriteLine("ERROR!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
