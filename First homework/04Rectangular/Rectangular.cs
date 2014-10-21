using System;

class Rectangular
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double p = 2 * width + 2 * height;
        double a = width * height;
        Console.WriteLine(p);
        Console.WriteLine(a);
    }
}

