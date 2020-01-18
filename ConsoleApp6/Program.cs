using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This is an application for getting a shipping quote for a package");
            Console.WriteLine("Starting program...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("");

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("");

            Console.Write("Enter package weight: ");
            string pkg_lbs_str = Console.ReadLine();
            int pkg_lbs = Convert.ToInt32(pkg_lbs_str);

            if (pkg_lbs > 50)
            {
                Console.WriteLine("");
                Console.WriteLine("Package is too damn heavy to be shipped via Package Express.");
                Environment.Exit(26);
            }

            Console.WriteLine("");
            Console.WriteLine("Thank you, now enter package dimensions.");
            Console.WriteLine("");

            Console.Write("Enter package width: ");
            string width_str = Console.ReadLine();
            int width = Convert.ToInt32(width_str);
            Console.Write("Enter package height: ");
            string height_str = Console.ReadLine();
            int height = Convert.ToInt32(height_str);
            Console.Write("Enter package length: ");
            string length_str = Console.ReadLine();
            int length = Convert.ToInt32(length_str);

            if (width + height + length > 50)
            {

                Console.WriteLine("");
                Console.WriteLine("Package is too damn big to be shipped via Package Express.");
                Environment.Exit(42);
            }

            float quote = width * height * length * pkg_lbs / 100;
            Console.WriteLine("");
            Console.WriteLine("Your total for shipping this package is $" + quote + ".");
           
        }
    }
}
