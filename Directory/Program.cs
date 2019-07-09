using System;
using System.IO;

namespace Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Uchiha Martins\source\repos\IO\Directory\IO");
            directoryInfo.Create();

            if (directoryInfo.Exists)
            {
                directoryInfo.Delete();

                Console.WriteLine("Deletado com sucesso!");
            }
            

            Console.ReadLine();

        }
    }
}
