using System;

class OddEvenNumbers
{
    static void Main()
    {
        long count = long.Parse(Console.ReadLine());
        long oddSum = 0;
        long evenSum = 0;

        
        for (int i = 0; i < count*2; i++)
        {
            long n = long.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += n;
            }
            else
                {
                    oddSum += n;
                }
        }
       
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum={0}", oddSum);
            }
            else if (oddSum > evenSum)
            {
                Console.WriteLine("No, diff={0}", oddSum - evenSum);
            }
            else if (oddSum < evenSum)
            {
                Console.WriteLine("No, diff={0}", evenSum - oddSum);
            }
        }
    }

    

