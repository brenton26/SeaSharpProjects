using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Type a number to count down from: ");
            string num_str = Console.ReadLine();
            int num = Convert.ToInt32(num_str);
            while (num >= 0)
            {
                Console.WriteLine(num);
                num--;
            }

            Console.Write("Now, guess my favorite color: ");
            string color = Console.ReadLine();
            do
            {
                switch (color)
                {
                    case "blue":
                        Console.WriteLine("Fuck you, I hate blue");
                        Console.Write("Guess again: ");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("Yellow is bland");
                        Console.Write("Guess again: ");
                        color = Console.ReadLine();
                        break;
                    case "black":
                        Console.WriteLine("Decent guess, but wrong");
                        Console.Write("Guess again: ");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("Close! That's number 2, but still wrong");
                        Console.Write("Guess again: ");
                        color = Console.ReadLine();
                        break;
                    case "orange":
                        Console.WriteLine("Nah, orange is too hard to look at");
                        Console.Write("Guess again: ");
                        color = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Nope, wrong");
                        Console.Write("Guess again: ");
                        color = Console.ReadLine();
                        break;

                }
            }
            while (color != "red");

            Console.WriteLine("Fuckin Hell mate! Ya got it!");
        }
    }
}
