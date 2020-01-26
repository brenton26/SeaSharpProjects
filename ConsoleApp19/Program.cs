using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            sNumber number1 = new sNumber();
            sNumber number2 = number1;
            number1.Amount = 3.14159M;
            number2.Amount = 10M;

            cNumber number3 = new cNumber();
            cNumber number4 = number3;
            number3.Amount = 3.14159M;
            number4.Amount = 10M;

            Console.WriteLine("Number 1: " + number1.Amount);
            Console.WriteLine("Number 2: " + number2.Amount);
            Console.WriteLine("Number 3: " + number3.Amount);
            Console.WriteLine("Number 4: " + number4.Amount);
        }
    }

    public struct sNumber
    {
        public decimal Amount { get; set; }
    }
    public class cNumber
    {
        public decimal Amount { get; set; }
    }
}
