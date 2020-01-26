using System;
using System.Collections.Generic;
namespace ConsoleApp17
{
    public class Employee<T> : Person, IQuitable
    {
        public Employee()
        {
            Say_Name();
        }
        public int ID { get; set; }
        public bool Current_Employee { get; set; }
        public List<T> Things { get; set; }


        public void Quit()
        {
            Current_Employee = false;
            Console.WriteLine(this.FirstName + " " + this.LastName + " has quit.");
            Console.WriteLine("Current Employee: " + Current_Employee);
        }
        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
        {
            bool isSame = employee1.ID == employee2.ID;
            return isSame;
        }
        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
        {
            bool isSame = employee1.ID != employee2.ID;
            return isSame;
        }
        public override bool Equals(object o)
        {
            return true;
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public void PrintThings(Employee<T> employee)
        {
            foreach (var item in employee.Things)
            {
                Console.Write(item + " ");
            }
        }


    }
}
