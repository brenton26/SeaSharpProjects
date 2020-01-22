using System;
namespace ConsoleApp15
{
    public class MathClass
    {
        public MathClass()
        {
        }
        public int Value { get; set; }

        public void divide_by2()
        {
            double dub_result = Value / 2;
            Value = Convert.ToInt32(dub_result);
        }

        public static int times2(int input, out int output)
        {
            output = input * 2;
            return output;
        }
        
    }
}
