using System;

namespace DateTimez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("It is currently: ");
            DateTime right_now = DateTime.Now;
            Console.WriteLine(right_now);
            Console.Write("Type a number: ");
            int user_input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In " + user_input + " hours it will be " + right_now.AddHours(user_input));
            Console.WriteLine("In " + user_input + " years it will be " + right_now.AddYears(user_input));
        }
    }
}
