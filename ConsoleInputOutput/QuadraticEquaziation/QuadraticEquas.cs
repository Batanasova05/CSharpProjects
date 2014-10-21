using System;




class QuadraticEquas
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double disc = (b*b) - 4 * a * c;
        double x = -b / 2 / a;
        double x1 = (-b + Math.Sqrt(disc)) /2 /a;
        double x2 = (-b - Math.Sqrt(disc)) / 2 / a;

        if (disc < 0)
        {
            Console.WriteLine(" No real roots");
        }
        else if (disc == 0)
        {
            
            Console.WriteLine("the root is x1 = x2 = {0}", x);
        }

        else
        {
            Console.WriteLine("The solution of the equation is : {0} {1}", x1, x2);
        }

   
    }
}

