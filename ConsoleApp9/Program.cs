using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            string[] array_of_colors = {
                "Red",
                "Orange",
                "Yellow",
                "Green",
                "Blue",
                "Indigo",
                "Violet",
                "Purple",
                "Pink",
                "Black",
                "Gray",
            };
            Console.Write("Choose an index 0-10: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice < 0 || choice > 10)
            {
                Console.WriteLine("What a fucking dumbass, I said choose an index between 1 and 10.");
            }
            else
            {
                Console.WriteLine(array_of_colors[choice]);
            }
            
        }
    }
}
