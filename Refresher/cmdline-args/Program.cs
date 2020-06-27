using System;


namespace cmdline_args
{
    class Program
    {
        /* Gyan 2
         * The Main method, which is a starting point for a C# application, can be declared with a string[] parameter.
         * The parameter, which is an array, provides access to arguments supplied at the command-line when the executable is run.
         * The first element of the array is the first argument to the executable and not the name / path of the executable as in C/C++.
        */
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
