using System;
using System.IO;

namespace DirectorsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\siim.jarveots\samples";
            Console.WriteLine("Enter directory name:");
            //string newDirectory = @"wishlist";
            string newDirectory = Console.ReadLine();
            //string fileName = "wishlist.txt";
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();




            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                //Console.WriteLine($"Directory {newDirectory} exists at {rootDirectory}");
                Console.WriteLine("Directory and File exist.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }
        }
    }
}
