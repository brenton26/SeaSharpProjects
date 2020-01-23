using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee a0001 = new Employee
            {
                First_Name = "Billy",
                Last_Name = "Jones",
                ID = 0001
            };
            a0001.Say_Name();
        }
    }
}
