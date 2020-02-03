using System;
using System.IO;

namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write some text to store to a file.");
            Console.Write(": ");
            string user_input = Console.ReadLine();
            using (StreamWriter file = new StreamWriter("/Users/brentonturner/desktop/file.txt", true))
            {
                file.WriteLine(user_input);
            }
            Console.WriteLine("---\nThank you. Your input has been saved to file.txt.");
            Console.WriteLine("---\nHere are the current contents of that file:\n");
            Console.WriteLine(File.ReadAllText("/Users/brentonturner/desktop/file.txt"));
            
        }
    }
}
