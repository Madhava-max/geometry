using System;

namespace geometry1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            int start_X,start_Y,end_X,end_Y;

            Console.WriteLine("give the value of start_X");
            start_X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give the value of start_Y");
            start_Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give the value of end_X");
            end_X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give the value of end_Y");
            end_Y = Convert.ToInt32(Console.ReadLine());
            double length = 0;
            length = Math.Sqrt(Math.Pow((end_Y - start_Y), 2) + Math.Pow((end_X - start_X), 2));
            Console.WriteLine("THE LENGTH OF THE LINE IS " + length);


        }
    }
}
