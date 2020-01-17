using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Give a number: ");
            string ans1 = Console.ReadLine();
            int num1 = Convert.ToInt32(ans1);
            int num50 = num1 * 50;
            Console.WriteLine("Your damn number multiplied by 50 is " + num50);
            Console.WriteLine("Give a another number: ");
            string ans2 = Console.ReadLine();
            int num2 = Convert.ToInt32(ans2);
            bool isItBiggerThanFifty = 50 < num2;
            Console.WriteLine("The fact that that number is greater than 50 is " + isItBiggerThanFifty);

        }
    }
}
