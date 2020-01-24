using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee a0001 = new Employee
            {
                FirstName = "Ebeneezer",
                LastName = "Scrooge"
            };
            a0001.Say_Name();
            Console.WriteLine("Hello World!");
        }
    }
}
