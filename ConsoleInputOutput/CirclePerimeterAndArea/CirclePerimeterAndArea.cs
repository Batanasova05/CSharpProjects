using System;




class CirclePerimeterAndArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double area = pi * Math.Pow(r,2);
        double perimeter = 2 * pi * r;

        Console.WriteLine("The circle's area is: {0:F2}", area);
        Console.WriteLine("The circle's perimeter is: {0:F2}", perimeter);

    }
}

