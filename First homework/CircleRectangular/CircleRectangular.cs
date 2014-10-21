using System;


class CircleRectangular
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = (((Math.Pow(x-1,2)) + (Math.Pow(y-1,2)) <=1.5*1.5));
        bool isInRectangular = (x<=5 && x >= -1) && (y >=-1 && y <= 1);
        if (isInCircle && !isInRectangular)
        {
            Console.WriteLine("yes");

        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

