using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person1();
            person1.SetBirthdate(new DateTime(1986, 3, 25));
            Console.WriteLine(person1.GetDate());

            var person2 = new Person2 { Birthdate = new DateTime(1989, 4, 1) };
            Console.WriteLine(person2.Birthdate);

            var person3 = new Person3 { Birthdate = new DateTime(1985, 12, 4) };
            Console.WriteLine(person3.Birthdate);
            Console.WriteLine(person3.Age);

        }
    }

    public class Person1
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }
        public DateTime GetDate()
        {
            return this._birthdate;
        }
    }

    public class Person2
    {
        private DateTime _birthdate;

        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
    }

    public class Person3
    {
        public DateTime Birthdate { get; set; }

        public int Age
        {
            get
            {
                var time_span = DateTime.Today - Birthdate;
                var years = time_span.Days/365;
                return years;
            }
        }
    }

    public class Person4
    {
        public DateTime Birthdate { get; private set; } // use prvite here so that this can only set set once (must use constructor to set)

        public Person4(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var time_span = DateTime.Today - Birthdate;
                var years = time_span.Days / 365;
                return years;
            }
        }
    }
}
