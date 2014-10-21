using System;
using System.Numerics;


class Tribonaci
{
    static void Main()
    {
        BigInteger t1 = BigInteger.Parse(Console.ReadLine());
        BigInteger t2 = BigInteger.Parse(Console.ReadLine());
        BigInteger t3 = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger result = 0;
        if (n == 1)
        {
            result = 1;
        }
        else if (n == 2)
        {
            result = 2;
        }
        else if (n == 3)
        {
            result = 3;
        }
        else
        {

            for (int i = 3; i < n; i++)
            {

                BigInteger num = t1 + t2 + t3;
                t1 = t2;
                t2 = t3;
                t3 = num;
                result = t3;
            }
            Console.WriteLine(result);
        }
    }
}
