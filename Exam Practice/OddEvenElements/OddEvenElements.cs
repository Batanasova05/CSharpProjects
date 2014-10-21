using System;

class OddEvenElements
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;
        double sumOdd = 0;
        double sumEven = 0;

        for (int i = 0; i < input.Length; i++)
        {
            double tempNumber = double.Parse(input[i]);

            if (i%2 == 0)
            {
                sumOdd += tempNumber;
                oddMin = Math.Min(oddMin, tempNumber);
                oddMax = Math.Max(oddMax, tempNumber);
            }
            else  
	        {
              sumEven += tempNumber;
              evenMin = Math.Min(oddMin, tempNumber);
              evenMax = Math.Max(oddMax, tempNumber);
	        }
        }
        if (input.Length == 0)
        {
            Console.WriteLine("OddSum=0, OddMin=0, OddMax=0, EvenSum=0, EvenMin=0, EvenMax=0");
        }
        else if (input.Length == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", sumOdd,oddMin,oddMax);
        }
        
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",sumOdd,oddMin,oddMax,sumEven,evenMin,evenMax);
        }
    }
}

