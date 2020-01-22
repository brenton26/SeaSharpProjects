using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Give a damn number: ");
                decimal user_input = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Optional: How much bigger do you want to make it: ");
                string user_input_str = Console.ReadLine();

                if (user_input_str == "" || user_input_str == " ")
                {
                    Console.WriteLine("Well, all you did was enter the number " + user_input + ". \nWhat was even the point of using this program?");
                }
                else
                {
                    decimal user_input2 = Convert.ToDecimal(user_input_str);
                    decimal result = MyClass.my_method(user_input, user_input2);
                    Console.WriteLine("The result is: " + result);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Type a number next time.");
            }
        }
    }
}
