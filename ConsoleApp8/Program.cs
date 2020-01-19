using System;
using System.Text;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the String builder App!");
            Console.WriteLine("Enter 3 strings:");
            Console.Write("1. ");
            string string1 = Console.ReadLine();
            Console.Write("2. ");
            string string2 = Console.ReadLine();
            Console.Write("3. ");
            string string3 = Console.ReadLine();
            string string4 = string1 + string2 + string3;            
            Console.WriteLine(string4.ToUpper());

            Console.WriteLine("");

            StringBuilder sentence = new StringBuilder();

            Console.WriteLine("Create a sentence one word at a time.");
            Console.WriteLine("Type exit to stop.");
            
            string word;

            do
            {
                Console.Write("Enter word: ");
                word = Console.ReadLine();
                sentence.Append(" " + word);
                Console.WriteLine(sentence);
            }
            while (word != "exit");

            Console.WriteLine("Thanks for using my string builder program.");
            Console.WriteLine("See ya next time.");
        }
    }
}
