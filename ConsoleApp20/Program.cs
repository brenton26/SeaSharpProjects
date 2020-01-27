using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Kyle", 1));
            employees.Add(new Employee("Brenton", 2));
            employees.Add(new Employee("Brion", 3));
            employees.Add(new Employee("Kelly", 4));
            employees.Add(new Employee("Casey", 5));
            employees.Add(new Employee("Chris", 6));
            employees.Add(new Employee("Josh", 7));
            employees.Add(new Employee("Jeff", 8));
            employees.Add(new Employee("Taylor", 9));
            employees.Add(new Employee("Ben", 10));
            employees.Add(new Employee("Jared", 11));
            employees.Add(new Employee("Elizabeth", 12));
            employees.Add(new Employee("Shannon", 13));
            employees.Add(new Employee("Nancy", 14));
            employees.Add(new Employee("Casey", 15));

            List<Employee> Casey_List = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.Name == "Casey")
                {
                    Casey_List.Add(employee);
                }
            }
            foreach (Employee employee in Casey_List)
            {
                Console.WriteLine(employee.Name);
            }

            List<Employee> Casey_List2 = employees.Where(x => x.Name == "Casey" ).ToList();
            foreach (Employee employee in Casey_List2)
            {
                Console.WriteLine(employee.Name);
            }

            List<Employee> Even_Id = employees.Where(x => x.ID % 2 == 0).ToList();
            foreach (Employee employee in Even_Id)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
    public class Employee
    {
        public Employee(string name, int id)
        {
            this.Name = name;
            this.ID = id;
            }
        public string Name { get; set; }
        public int ID { get; set; }
    }


}
