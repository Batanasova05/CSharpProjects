using System;


class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outterDots =n/2;
        int dots = 1;
        int innerDots = (n * 2 - 1) - 2 - 2 * dots;

        Console.WriteLine("{0}{1}{0}", new string ('.', outterDots),new string ('#',n) );
        for (int i = 0; i < n-2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string ('.', outterDots),new string ('.', n-2) );
        }
        Console.WriteLine("{0}{1}{0}", new string ('#', n/2+1),new string ('.', n-2));

        for (int i = 0; i < n-2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string ('.', dots), new string ('.', innerDots));
            dots++;
            innerDots -= 2;
        }

        Console.WriteLine("{0}#{0}", new string ('.',n-1));
    }
}

