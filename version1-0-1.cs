using System;
using System.IO;

namespace _1bitsound
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Path:");
            string pathin = Console.ReadLine();
            Console.WriteLine("Output Path:");
            string pathout = Console.ReadLine();
            byte[] infile = File.ReadAllBytes(pathin);
            int fileptr = 0;
            for (fileptr = 0; fileptr < infile.Length; fileptr++)
            {
                infile[fileptr] = Convert.ToByte(infile[fileptr] & 0b10000000);
            }
            File.WriteAllBytes(pathout, infile);
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}