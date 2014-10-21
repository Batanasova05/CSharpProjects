using System;

    class MinMax
    {
        static void Main()
        
        {
            int n = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int min = num;
            int max = num;
            int sum = num;
            double avg = sum;
            for (int i = 1; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
                sum = sum + num;
                avg = (double)sum / n;
            }
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2}", avg);
    }

        }
    

