using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            Console.WriteLine("Welcome to Ed's exceptional Exception Handling program!");
            bool completed = false;
            while (!completed)
            {
                try
                {
                    Console.Write("How old are you?: ");
                    int user_age = Convert.ToInt32(Console.ReadLine());
                    if (user_age == 0) { throw new AgeCantBeZeroException(); }
                    if (user_age < 0) { throw new AgeCantBeNegativeException(); }
                    DateTime now = DateTime.Now;
                    int this_year = now.Year;
                    int year_born = this_year - user_age;
                    Console.WriteLine("You were born in the year {0} (plus or minus a year).", year_born);
                    completed = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please type a number.");
                }
                catch (AgeCantBeZeroException)
                {
                    Console.WriteLine("Your age can't be zero.");
                }
                catch (AgeCantBeNegativeException)
                {
                    Console.WriteLine("Your age can't be negative.");
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occured.");
                }
            }
        }
    }
    public class AgeCantBeZeroException : Exception
    {
        public AgeCantBeZeroException() : base() { }
        public AgeCantBeZeroException(string message) : base(message) { }
    }
    public class AgeCantBeNegativeException : Exception
    {
        public AgeCantBeNegativeException() : base() { }
        public AgeCantBeNegativeException(string message) : base(message) { }
    }
}
