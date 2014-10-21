using System;




    class PrimeNumbers
    {
        static void Main()
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            bool isPrime = true;
            for (int i = 2; i < n; i++) 
            if (n>=1)
            {
            {
               if (n%i == 0) 
                { 
                    isPrime = false;

                }
            }
            Console.WriteLine(isPrime);
         
        }
        }

    }

