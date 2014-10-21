using System;

    class Triangle
    {
        static void Main()
        {
            int ax = int.Parse(Console.ReadLine());
            int ay = int.Parse(Console.ReadLine());
            int bx = int.Parse(Console.ReadLine());
            int by = int.Parse(Console.ReadLine());
            int cx = int.Parse(Console.ReadLine());
            int cy = int.Parse(Console.ReadLine());
            double b = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
            double a = Math.Sqrt(Math.Pow(bx-ax,2) + Math.Pow(by-ay,2));
            double c = Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2));
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));


            if (a+b>c && b+c>a && a+c>b)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0:0.00}", area);
            }
            else
            {
                Console.WriteLine( "No");
                Console.WriteLine("{0:0.00}",a);
            }

        }
    }

