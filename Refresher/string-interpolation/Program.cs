using System;

namespace string_interpolation
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            /* Gyan 5
             * String interpolation means substituting C# expressions embedded inside a string literal with their values.
             * A string literal is interpolated by preceding it with the '$' symbol; C# expressions enclosed by pairs of braces are replaced with their values.
             * Below, the string argument is interpolated and the variable 'i' and the expression 'i + 1' are replaced with their respective values.
             */
            Console.WriteLine($"i: {i}, next i: {i + 1}");
        }
    }
}
