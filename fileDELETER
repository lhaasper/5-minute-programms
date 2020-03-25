//took me approx. 20 minutes since I was adding a feature which I later removed due to some errors which I couldn't explain myself
//made by lhaasper
//works simple

using System;
using System.IO;
using System.Threading;

namespace fileDELETER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Deleter");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("[1] Delete file ");
            string option = Console.ReadLine();
            if (option == "1")
            {
                Console.Clear();
                Console.WriteLine("Please input the path to the file: ");
                string pathtodeletefile = Console.ReadLine();
                try
                {
                    if (File.Exists(pathtodeletefile))
                    {
                        File.Delete(pathtodeletefile);
                        Console.WriteLine("File deleted.");
                    }
                    else Console.WriteLine("File not found");
                }
                catch (IOException)
                {
                    Console.WriteLine("Access denied! Run the files as administrator and try again");
                }
                Thread.Sleep(2000);

            }
        }
    }
}
