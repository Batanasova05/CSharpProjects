using System;

    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine()); 
            int h = holidays/2;
            int w = ( ((52 - weekends) *2/3) + weekends );
            double  total = h + w;

            if (year == "t")
            {
                Console.WriteLine(total + 3);
            }

            else
            {
                Console.WriteLine(total);
            }
        }
    }

