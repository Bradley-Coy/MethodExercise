using System;
namespace Method_Exercise_2
{
    public class Methods
    {
        public static int Add_1(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Add_2(params int[] values)
        {
            int sum = 0;
            foreach (int num in values)
            {
                sum += num;
            }

            return sum;
        }

        public static int Mult(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }

        public static int Mod(int x, int y)
        {
            return x % y;
        }
       
        internal static void Add()
        {
            throw new NotImplementedException();
        }
    }
}