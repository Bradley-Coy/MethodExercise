using System;
namespace Method_Exercise_2
{
    public class Methods
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        internal static void Add()
        {
            throw new NotImplementedException();
        }
    }
}