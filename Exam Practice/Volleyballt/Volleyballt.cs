using System;

    class Volleyballt
    {
        static void Main()
        {
            string year = Console.ReadLine();
            double holiday = int.Parse(Console.ReadLine());
            double weekend = int.Parse(Console.ReadLine());
            double h = holiday*2/3;
            double w = ((48-weekend)*3/4 + weekend);
            double total = h + w;

            if (year == "leap")
            {
                Console.WriteLine(Math.Floor(total + (total * 0.15)));
            }
            else
            {
                Console.WriteLine(Math.Floor(total));
            }
        }
    }

