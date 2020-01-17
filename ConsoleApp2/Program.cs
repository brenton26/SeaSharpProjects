using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Brenton's really awesome program\n");
            Console.WriteLine("I got some questions to ask you\n");
            Console.WriteLine("What course are you on? :");
            string course = Console.ReadLine();
            Console.WriteLine("What page number? :");
            string page = Console.ReadLine();
            Console.WriteLine("Thanks for submiting your answers, you're on the " + course + " course and are are page " + page);
            
        }
    }
}
