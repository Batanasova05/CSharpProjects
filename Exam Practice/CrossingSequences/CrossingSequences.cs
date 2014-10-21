using System;
using System.Numerics;

class CrossingSequences
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());
        BigInteger d = BigInteger.Parse(Console.ReadLine());
        BigInteger e = BigInteger.Parse(Console.ReadLine());
        BigInteger result = 0;
       
        for (BigInteger i = 0; i <= 1000000; i++)
        {
            BigInteger num = a + b + c;
            if (result<=1000000)
            {
                a = b;
                b = c;
                c = num;
                result = num;
                Console.WriteLine(result);
            }

           
            {
                
            }
        }

        
    }
}

