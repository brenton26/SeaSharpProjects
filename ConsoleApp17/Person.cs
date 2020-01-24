using System;
namespace ConsoleApp17
{
    public abstract class Person
    {
        public Person()
        {
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Say_Name()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
