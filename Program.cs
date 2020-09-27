using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = RandNumber(), y1 = RandNumber();
            int x2 = RandNumber(), y2 = RandNumber();
            Console.WriteLine("Start Point of Line1: ({0}, {0})", x1,y1);
            Console.WriteLine("End Point of Line1: ({0}, {0})", x2, y2);
            double length_1 = Distance(x1, y1, x2, y2);
            Console.WriteLine("Length of Line1: {0}", length_1);
            int x_1 = RandNumber(), y_1 = RandNumber();
            int x_2 = RandNumber(), y_2 = RandNumber();
            Console.WriteLine("Start Point of Line2: ({0}, {0})", x_1, y_1);
            Console.WriteLine("End Point of Line2: ({0}, {0})", x_2, y_2);
            double length_2 = Distance(x_1, y_1, x_2, y_2);
            Console.WriteLine("Length of Line2: {0}", length_2);
            if (length_1 > length_2)
            {
                Console.WriteLine("Line1 is longer than line2");
            }
            else if(length_2>length_1)
            {
                Console.WriteLine("Line2 is longer than line1");
            }
            else
            {
                Console.WriteLine("Both lines are of equal length");
            }
        }

        static int RandNumber()
        {
            Random randObj = new Random();
            return randObj.Next(1, 100);
        }

        static double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
    }
}
