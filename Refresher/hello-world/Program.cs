/* Gyan 1
 * A basic C#.NET application that displays text in the console consists of calling the WriteLine method of the Console class.
 * The Console class lives in the System namespace. Hence we put a using declaration here.
 */
using System;

/* Gyan 1.1
 * A namespace definition is not absolutely necessary, but it's good to have one.
 */
namespace hello_world
{
    /* Gyan 1.2
     * There must be at least one class definition.
     */
    class Program
    {
        /* Gyan 1.3
         * At least one of the classes must contain a static method named Main, which is the entry point for the application.
         */
        static void Main()
        {
            /* Gyan 1.4
             * Text can be written to the standard output terminal using WriteLine method of the Console class.
             */
            Console.WriteLine("Hello World!");
        }
    }
}
