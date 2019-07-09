using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GetDirectory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Directory.GetCurrentDirectory());

            string[] directory = Directory.GetDirectories(@"C:\");

            foreach (string pastas in directory)
                Console.WriteLine(pastas);

            Exibir();

            string[] directoryFile = Directory.GetFiles(@"D:\Alura\CursoDeAndroid", "*.mp4", SearchOption.AllDirectories);

            foreach (string files in directoryFile)
            {
                Console.WriteLine(files);
            }

            Exibir();

        }

        private static void Exibir()
        {
            Console.WriteLine("Executado com sucesso");
            Console.ReadLine();
        }
    }
}
