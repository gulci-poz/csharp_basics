using System;

namespace hello_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // args zawiera tylko podane argumenty, bez ścieżki z nazwą programu jako zerowy argument
            // C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe Program.cs
            if(args.Length != 0)
            {
                Console.WriteLine("Hello args, " + args[0] + "!");
            }
            else
            {
                Console.WriteLine("Hello no args!");
            }


            if(DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("Another case of the Mondays!");
            }
            else
            {
                Console.WriteLine("Today is: " + DateTime.Now.DayOfWeek);
            }


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
