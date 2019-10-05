using HelloLibrary;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                throw new Exception("To run the application, you need to pass at least one parameter");
            }

            string message = HelloClass.GenerateWelcomeString(DateTime.Now, args[0]);

            Console.WriteLine(message);
        }
    }
}
