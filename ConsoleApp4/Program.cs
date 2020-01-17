using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("");
            Console.WriteLine("Starting Anonymous Income Comparison Program...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("");

            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate: ");
            string person1_income_str = Console.ReadLine();
            int person1_income = Convert.ToInt32(person1_income_str);
            Console.Write("Hours worked per week: ");
            string person1_hours_wk_str = Console.ReadLine();
            int person1_hours_wk = Convert.ToInt32(person1_hours_wk_str);
            Console.WriteLine("");

            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate: ");
            string person2_income_str = Console.ReadLine();
            int person2_income = Convert.ToInt32(person2_income_str);
            Console.Write("Hours worked per week: ");
            string person2_hours_wk_str = Console.ReadLine();
            int person2_hours_wk = Convert.ToInt32(person2_hours_wk_str);
            Console.WriteLine("");

            int person1_annual = person1_income * person1_hours_wk * 52;
            int person2_annual = person2_income * person2_hours_wk * 52;
            bool does_p1_make_more_than_p2 = person1_annual > person2_annual;

            Console.WriteLine("Calculating...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("");

            Console.WriteLine("Person 1 makes $" + person1_annual + " per year.");
            Console.WriteLine("Person 2 makes $" + person2_annual + " per year.");
            Console.WriteLine("Does Person 1 make more money than person 2?");
            Console.WriteLine(does_p1_make_more_than_p2);
        }
    }
}
