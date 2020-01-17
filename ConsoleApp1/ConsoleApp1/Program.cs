using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What the hell is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Fuck you, " + name + "!");
            Console.Read();       
        }
    }
}
