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
                if (infile[fileptr] > 0x7f)
                {
                    infile[fileptr] = 0xff;
                }
                if (infile[fileptr] < 0x7f)
                {
                    infile[fileptr] = 0x00;
                }
                if (infile[fileptr] == 0x7f)
                {
                    infile[fileptr] = 0x00;
                }
            }
            File.WriteAllBytes(pathout, infile);
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}