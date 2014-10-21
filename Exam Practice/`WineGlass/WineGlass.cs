using System;

class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int backslash = 1;
        int slash =1;
        int outterDots = 1;
        int innerStars = n - 4;
        int vertical =1;
        
        Console.WriteLine("\\{0}/", new string ('*',n-2));
        for (int i = 0; i < n/2-1; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}", new string ('.', outterDots), new string ('*', innerStars));
            outterDots++;
            innerStars-=2;
        }
        if (n<12)
        {
            for (int i = 0; i < n / 2 - 1; i++)
            {

                Console.WriteLine("{0}{1}{0}", new string('.', n / 2 - 1), new string('|', 2 * vertical));
            }
            Console.WriteLine("{0}", new string('-', n));
        }
        else if (n >=12)
        {
            for (int i = 0; i < n / 2 - 2; i++)
            {

                Console.WriteLine("{0}{1}{0}", new string('.', n / 2 - 1), new string('|', 2 * vertical));
            }

            Console.WriteLine("{0}", new string('-', n));
            Console.WriteLine("{0}", new string('-', n));
        }
                                     
	         }                         
    }


