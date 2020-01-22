using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int my_int = 5;
            decimal my_decimal = 5.0m;
            string my_string = "5";
            int result;


            MathClass.Add64(my_int, out result);
            Console.WriteLine(result);

            MathClass.Add64(my_decimal, out result);
            Console.WriteLine(result);

            MathClass.Add64(my_string, out result);
            Console.WriteLine(result);

        }
    }

    public class MathClass
    {
        public static int Add64(int my_int, out int result)
        {
            result = my_int + 64;
            return my_int;
        }

        public static int Add64(decimal my_decimal, out int result)
        {
            int converted = Convert.ToInt32(my_decimal);
            result = (converted + 64) * -1;
            return result;
        }
        public static int Add64(string my_string, out int result)
        {
            int converted = Convert.ToInt32(my_string);
            result = converted * 11111111;
            return result;
        }
    }                                                               
}
