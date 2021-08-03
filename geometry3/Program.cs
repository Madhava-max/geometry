using System;

namespace geometry3
{
    class Program
    {
        static void Main(string[] args)
        {
            int start_X, start_Y, end_X, end_Y;

            Console.WriteLine("give the value of start_X");
            start_X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give the value of start_Y");
            start_Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give the value of end_X");
            end_X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give the value of end_Y");
            end_Y = Convert.ToInt32(Console.ReadLine());
            double length1 = 0;
            length1 = Math.Sqrt(Math.Pow((end_Y - start_Y), 2) + Math.Pow((end_X - start_X), 2));
            int start_X3, start_Y3, end_X4, end_Y4;

            Console.WriteLine("give the value of start_X3");
            start_X3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give the value of start_Y3");
            start_Y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give the value of end_X4");
            end_X4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give the value of end_Y4");
            end_Y4 = Convert.ToInt32(Console.ReadLine());
            double length2 = 0;
            length2 = Math.Sqrt(Math.Pow((end_Y4 - start_Y3), 2) + Math.Pow((end_X4 - start_X3), 2));
            if (length1 == length2)
            {
                Console.WriteLine("both lines are equal");
            }
            else if (length1 > length2)
            {
                Console.WriteLine("length1 is greater than length2");
            }
            else 
            {
                Console.WriteLine("length1 is lesser than length2");
            }

        }
    }
}
