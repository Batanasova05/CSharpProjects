using System;


class Gravity
{
    static void Main()
    {
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnMoon = weightOnEarth * 0.17;
        Console.WriteLine(weightOnMoon);
    }
}

