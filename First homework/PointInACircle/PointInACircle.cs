using System;



    class PointInACircle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool isInCircel = (((x*x) + (y*y)) <=2*2);
            Console.WriteLine(isInCircel);
            

        }
    }

