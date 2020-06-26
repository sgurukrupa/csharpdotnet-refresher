using System;

namespace cmdline_args
{
    class Program
    {
        static void PrintArgs(string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
        }

        static void Main(string[] args)
        {
            PrintArgs(args);
        }
    }
}
