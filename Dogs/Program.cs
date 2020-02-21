using System;
using System.Collections.Generic;

namespace Dogs
{
    // Program Class
    class Program
    {
        static void Main(string[] args)
        {
            var index = new Index();
            var dog1 = new Dog("Fluffy", "Rottweiler", 2);
            dog1.Speak();
            dog1.Introduce("Billy");

            var dog2 = Dog.Parse("Tim", "Mutt", 4);
            dog2.Speak();

            var g3 = new Dog();
            Console.WriteLine("dsss");

            //Console.WriteLine("Hello World!");
        }
    }


    // Dog Class
    public class Dog : Mammal
    {
        public Dog()
        {
        }
        public Dog(string name) : this()
        {
            this.Name = name;
        }
        public Dog(string name, string breed, int age) : this(name)
        {
            this.Breed = breed;
            this.Age = age;
        }
        public string Breed { get; set; }
        public int Age { get; set; }
        public bool IsGoodBoy = true;

        public override void Speak()
        {
            Console.WriteLine("{0} says \"WOOF WOOF!\"", Name);
        }
        public void Introduce(string to)
        {
            Console.WriteLine("{1} licks {0}'s face.", to, Name);
        }
        public static Dog Parse(string str, string str2, int int1)
        {
            var dog = new Dog(str, str2, int1);
            return dog;
        }
    }


    // Mammal Class
    public abstract class Mammal : Animal
    {
        public Mammal()
        {           
        }       
        new public bool IsWarmBlooded = true;
        public abstract void Speak();
    }


    // Animal Class
    public abstract class Animal
    {
        public Animal()
        {
            Index.Animals.Add(this);
        }
        public bool IsWarmBlooded { get; set; }
        public string Name { get; set; }
    }


    // Index Class
    public class Index
    {
        public Index()
        {
            Animals = new List<Animal>();
        }
        public static List<Animal> Animals;
    }
}
