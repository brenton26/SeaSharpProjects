using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            for (int i=0; i<3; i++)
            {
                try
                {                 
                    Console.Write("Hey Bro, What day of the week is it? ");
                    string input = Console.ReadLine();
                    Console.WriteLine("");
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input, true);
                    Console.WriteLine(day.GetHashCode());
                    Console.WriteLine(day.ToString());
                    Environment.Exit(1);

                }
                catch (FormatException)
                {
                    Console.WriteLine("You're an idiot, that's not a day of the week. ");
                    
                }
                catch(ArgumentException)
                {
                    Console.WriteLine("You're an idiot, that's not a day of the week. ");
                }
            }
            Console.WriteLine("Wow, you really don't know what the days of the week?");
        }
    }
}
