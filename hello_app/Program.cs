using System;

namespace hello_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // args zawiera tylko podane argumenty, bez ścieżki z nazwą programu jako zerowy argument
            //Console.WriteLine("Hello, " + args[0] + "!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("How many hours of sleep did you get last night? ");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name + "!");

            if (hoursOfSleep >= 8)
            {
                Console.WriteLine("You are well rested.");
            }
            else
            {
                Console.WriteLine("You need more sleep.");
            }
        }
    }
}
