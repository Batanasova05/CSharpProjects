using System;

    class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int midDash =1;
            int outterDash = width / 2 ;
            

            Console.WriteLine(new string('-', outterDash) + "*" + new string('-', outterDash));
            for (int i = 0; i < width/2; i++)
            {
                outterDash--;
                string outterDashesString = new string('-',outterDash);
                string midDashString = new string('-', midDash);
                Console.WriteLine(outterDashesString + "*" + midDashString + "*" + outterDashesString);
                midDash += 2;
            }
            midDash -= 2;
            for (int i = 0; i < width / 2-1; i++)
            {
                outterDash++;
                midDash -= 2;
                string outterDashesString = new string('-', outterDash);
                string midDashString = new string('-', midDash);
                Console.WriteLine(outterDashesString + "*" + midDashString + "*" + outterDashesString);
               
            }

            outterDash = width / 2;
            Console.WriteLine(new string('-', outterDash) + "*" + new string('-', outterDash));
            
        }
    }

