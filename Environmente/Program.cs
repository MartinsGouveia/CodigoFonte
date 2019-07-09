using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Environmente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "KnowYourPC";
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.Red;

            CultureInfo ci = new CultureInfo(CultureInfo.CurrentUICulture.ToString());

            Console.WriteLine("Idioma: {0}, Idioma Atual: {1}, Idioma Padrão: {2}", ci.Name, ci.NativeName, ci.TwoLetterISOLanguageName);

            Console.WriteLine(Console.CapsLock);

            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.Is64BitOperatingSystem);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.TickCount);
            Console.WriteLine(Environment.ProcessorCount);
            Console.WriteLine("Isso é: " + Environment.OSVersion.Platform.ToString());
            Console.WriteLine("Tentando: " + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));
            Console.WriteLine("64bit: " + Environment.Is64BitOperatingSystem);
            

                if(Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)))
                {
                    Console.WriteLine("é de 64");
                } else 
                {
                    Console.WriteLine("32");
                }


            ApplicationIdentity ap = new ApplicationIdentity("KnowYourPC");
            Console.WriteLine(ap);

            string[] drive = Environment.GetLogicalDrives();

            foreach (string drives in drive)
            {
                Console.WriteLine(drives);
            }

            Console.ReadLine();
        }
    }
}
