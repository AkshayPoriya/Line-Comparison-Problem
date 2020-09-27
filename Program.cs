using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = RandNumber(), y1 = RandNumber();
            int x2 = RandNumber(), y2 = RandNumber();
            Console.WriteLine("Start Point: ({0}, {0})", x1,y1);
            Console.WriteLine("End Point: ({0}, {0})", x2, y2);
            Console.WriteLine("Length of Line: {0}", Distance(x1,y1,x2,y2));
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
