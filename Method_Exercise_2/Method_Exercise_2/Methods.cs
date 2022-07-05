using System;
namespace Method_Exercise_2
{
    public class Methods
    {
        /*public static int Add(int x, int y)
        {
            return x + y;
        }*/
        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Add(params int[] values)
        {
            int sum = 0;
            foreach (int num in values)
            {
                sum += num;
            }

            return sum;
        }

       
        internal static void Add()
        {
            throw new NotImplementedException();
        }
    }
}