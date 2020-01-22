using System;
namespace ConsoleApp12
{
    public class MyCoolClass
    {
        public MyCoolClass()
        {
        }
        public static int Method1(int my_int)
        {
            my_int = my_int + my_int;
            return my_int;
        }
        public static int Method2(int my_int)
        {
            my_int = my_int * my_int;
            return my_int;
        }
        public static int Method3(int my_int)
        {
            my_int = my_int * my_int * my_int;
            return my_int;
        }
    }
}
