using System;

class DNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        int outterDots = n / 2;

        for (int i = 0; i < n-4; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string (('.'), outterDots), letter);
            outterDots--;
            letter++ ;
        }
    }
}

