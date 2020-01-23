using System;
namespace ConsoleApp15
{
    public static class StaticClass
    {
        public static int add2(int input, out int output)
        {
            output = input + 2;
            return output;
        }
    }
}
