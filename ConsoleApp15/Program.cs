using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i=0; i<3; i++)
            {
                try
                {
                    // Using void class method that creates a class object with a custom class attribute "Value".  
                    // User input is assigned as the Value for the new class object
                    // Class method can be called that changes the Value attribute by dividing it by two
                    Console.Write("Enter a number that you want to divide by two: ");
                    int input = Convert.ToInt32(Console.ReadLine());

                    MathClass math_item = new MathClass();
                    math_item.Value = input;

                    math_item.divide_by2();
                    Console.WriteLine("The result is " + math_item.Value);

                    // This uses a static class that just takes user input, multiples it by 2 and returns the result
                    Console.Write("Enter a number that you want to multiply by two: ");
                    int input2 = Convert.ToInt32(Console.ReadLine());

                    MathClass.times2(input2, out int output);
                    Console.WriteLine("The result is " + output);

                    Console.Write("Enter yet another number you want to add two to: ");
                    int input3 = Convert.ToInt32(Console.ReadLine());

                    StaticClass.add2(input3, out output);
                    Console.WriteLine("The result is " + output);

                    Environment.Exit(101);
          }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a whole number.");
                }
            }
            Console.WriteLine("You suck");



            
        }
    }
}
