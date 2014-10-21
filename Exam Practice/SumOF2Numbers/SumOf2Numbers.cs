using System;

    class SumOf2Numbers
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;


            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
               sum1 += number;
            }
            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
               sum2 += num;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum={0}", sum1);

            }

            if (sum1 > sum2)
            {
                Console.WriteLine("No, diff={0}", sum1 - sum2);
            }

            else (sum1 < sum2);
            {
                Console.WriteLine(" No, diff={0}", sum2 - sum1);
            }
        }
    }

