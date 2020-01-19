using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
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
                "Brown",
                "White",
                "Navy",
                "Teal",
                "Aqua",
                "Cyan",
                "Magenta",
                "Maroon",
            };
            Console.Write("Please input some text: ");
            string user_input = Console.ReadLine();

            for (int i=0; i<array_of_colors.Length; i++)
            {
                Console.Write("List Index: " + i + ". " + array_of_colors[i] + " " + user_input);
               
                if (user_input == array_of_colors[i])
                {
                    Console.Write(" YOU PICKED A COLOR FROM THE ARRAY!!! YAY!!!!");
                }
                Console.WriteLine("");
            }
            int count = 0;

            for (int i = 0; i<array_of_colors.Length; i++)
            {
                if (array_of_colors[i] != user_input)
                {
                    count++;
                }
            }
            if (count == array_of_colors.Length)
            {
                Console.WriteLine("Whatever the hell you typed does not match anything in the array.");
            }
        }
    }
}
