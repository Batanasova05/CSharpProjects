using System;

class BiggestNumOf3
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
       

        if ((a>b) && (a>c))
        {
            Console.WriteLine(a);
        }
        if ((a<b)&&(b>c))
        {
            Console.WriteLine(b);
        }
        if ((a<c)&&(b<c))
        {
            Console.WriteLine(c);
        }
    }
}

