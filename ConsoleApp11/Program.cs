using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] my_array = {2, 5, 10, 25, 26, 42, 64, 69, 100, 420, 1267, 2300, 6969, 1234560};
            List<int> my_list = new List<int>(my_array);

            Console.Write("Type a number to divide each number in the list by: ");
            
            try
            {
                decimal user_input = Convert.ToDecimal(Console.ReadLine());
                foreach (int item in my_list)
                {
                    decimal divided_num = item / user_input;
                    Console.WriteLine(item + " / " + user_input + " = " + divided_num);
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Type a number dumbass.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero, dumbass.");
            }

        }
    }
}
