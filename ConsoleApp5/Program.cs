using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Program");
            Console.Write("What's your age? ");
            string age_input = Console.ReadLine();
            int age = Convert.ToInt32(age_input);
            Console.Write("Have you ever had a DUI? (enter true or false): ");          
            string dui_input = Console.ReadLine();
            bool dui = Convert.ToBoolean(dui_input);
            Console.Write("How many tickets have you had? ");
            string num_tickets_input = Console.ReadLine();
            int ticket_num = Convert.ToInt32(num_tickets_input);
            bool qualified = (age > 15) && (dui == false) && (ticket_num <= 3);
            Console.WriteLine("Qualified?");
            Console.Write(qualified);

        }
    }
}
