using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(23, 4, 2, 567, 4, 345, 3, 456, 4, 546, 44, 5));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 25);
                Console.WriteLine(point.X + ", " + point.Y);

                point.Move(new Point(3, 33));
                Console.WriteLine(point.X + ", " + point.Y);

                point.Move(10, 3);
                Console.WriteLine(point.X + ", " + point.Y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured. {0}", ex);
            }
        }
    }
    class Point
    {
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X;
        public int Y;

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
            {
                throw new ArgumentException("newLocation");
            }
            Move(newLocation.X, newLocation.Y);
        }
        
    }

    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }

}
