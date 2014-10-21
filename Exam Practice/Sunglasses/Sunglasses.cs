using System;

    class Sunglasses
    {
        static void Main()
        {
            int h=int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('*',h*2), new string(' ', h) );

            for (int i = 0; i < h-2; i++)
            {
                if (i != h / 3)
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", "*", new string('/', h * 2 - 2), new string(' ', h));
                }
                else if (i==h/3)
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", "*", new string('/', h * 2 - 2), new string('|', h));
                }
            }

            Console.WriteLine("{0}{1}{0}", new string('*', h * 2), new string(' ', h));
        }
    }

