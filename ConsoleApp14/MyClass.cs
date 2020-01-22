using System;
namespace ConsoleApp14
{
    public class MyClass
    {
        public MyClass()
        {

        }
        public static decimal my_method(decimal x, decimal y = 0)
        {
            decimal z = x + y;

            return z;
        }

    }
}
