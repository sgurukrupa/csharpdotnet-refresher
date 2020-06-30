using System;

namespace declaration_statements
{
    class Program
    {
        static void Main()
        {
            /* Gyan 4
             * A constant is declared by preceding the variable declaration with the keyword 'const'.
             * A constant must always be initialized with a value.
             */
            const int i = 2;

            /* Gyan 4
             * A Variable is declared by following the type of the variable with an identifier.
             * The variable can be optionally initialized with a value.
             * Below, the variable 'j' is initialized, but the variable 'k' is not.
             */
            int j = i - 1, k;
            Console.WriteLine(j);

            /* Gyan 4.2
             * C# forbids the use of an unitialized variable in an expression.
             * Below, the variable 'k' is initialized with the value 0, before being used as argument for WriteLine method.
             */
            k = 0;
            Console.WriteLine(k);
        }
    }
}
