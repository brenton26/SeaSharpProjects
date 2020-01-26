using System;
using System.Collections.Generic;

namespace ConsoleApp17
{
    class Program
    {
        public static object PrintThings { get; private set; }

        static void Main(string[] args)
        {
            Employee<string> a0001 = new Employee<string>
            {
                FirstName = "Ebeneezer",
                LastName = "Scrooge",
                ID = 0001,
                Current_Employee = true,
                Things = new List<string> { "Hello", " ", "World" }
            };
            Employee<int> a0002 = new Employee<int>
            {
                FirstName = "John",
                LastName = "Doe",
                ID = 0002,
                Current_Employee = true,
                Things = new List<int> { 1, 2, 3, 4, 5 }
            };
            Employee<int> a0003 = new Employee<int>
            {
                FirstName = "Jason",
                LastName = "Bourne",
                ID = 0001,
                Current_Employee = true, 
                Things = new List<int> { 6, 7, 8, 9, 10 }
            };
            a0001.Say_Name();

            a0001.Quit();
            Console.WriteLine(a0002 == a0003);

            a0003.PrintThings(a0002);
            

        }

       
    }
}
