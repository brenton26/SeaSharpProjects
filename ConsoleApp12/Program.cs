using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey User, type a number to do some math operations on: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input);

            Console.WriteLine(MyCoolClass.Method1(input));
            Console.WriteLine(MyCoolClass.Method2(input));
            Console.WriteLine(MyCoolClass.Method3(input));



        }
    }
}
