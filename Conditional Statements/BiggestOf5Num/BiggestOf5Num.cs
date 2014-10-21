using System;

class BiggestOf5Num
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        if ((a > b) && (a > c)&& (a>d)&&(a>e))
        {
            Console.WriteLine(a);
        }
        if ((a < b) && (b > c)&& (b>d)&&(b>e))
        {
            Console.WriteLine(b);
        }
        if ((a < c) && (b < c)&&(c >d) && (c > e))
        {
            Console.WriteLine(c);
        }
        if ((a < d) && (b < d)&&(c < d) && (d >e ))
        {
            Console.WriteLine(d);
        }
        if ((a < e) && (b < e)&&(c < e) && (d < e))
        {
            Console.WriteLine(e);
        }
    }
}
