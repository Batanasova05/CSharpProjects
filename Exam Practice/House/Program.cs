using System;
class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outterDots = (n / 2 - 1);
        int innerDots = 1;


        Console.WriteLine("{0}*{0}", new string('.', (n / 2)));

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outterDots), new string('.', innerDots));
            outterDots--;
            innerDots += 2;
        }
        Console.WriteLine("{0}", new string('*', n));

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n / 4), new string('.', n - 2 - 2 * (n / 4)));

        }
        Console.WriteLine("{0}{1}{0}", new string ('.', n/4), new string ('*', n - 2*(n/4)));
    }
}
