using System;

namespace ex2
{
    class MainApp
    {
        public static void Main()
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5, mean);
            Console.WriteLine("평균: {0}", mean);
        }

        public static void Mean(
            double a, double b, double c,
            double d, double e, double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}