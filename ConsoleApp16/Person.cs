using System;
namespace ConsoleApp16
{
    public class Person
    {
        public Person()
        {
        }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public void Say_Name()
        {
            Console.WriteLine("Name: " + First_Name + " " + Last_Name);
        }
    }
}
