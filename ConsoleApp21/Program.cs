using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            const string my_first_name = "Billy";
            var my_last_name = "Jones";
            Dog dog1 = new Dog(my_first_name);

            Console.WriteLine(dog1.Breed);
        }
    }
    class Dog
    {
        public Dog(string name) : this(name, "Mutt", 1) { }
        public Dog(string name, string breed, int age)
            {
                Name = name;
                Breed = breed;
                Age = age;
            }

        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

    }
}
