using System;

class CalcultaN
{
    static void Main()
    {
        Console.Write(" N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write(" K = ");
        int k = int.Parse(Console.ReadLine());
        double faktK = 1;
        double faktN =1;

        if (1 > k && k > n && n > 100)
        {
            Console.WriteLine("Invalid input");
        }
        else
	{
            for (int i =1; i <= n ; i++)
        {
            
            faktN *= i;
        }
            for (int i = 1; i <= k; i++)
            {
                faktK *= i;
            }

            Console.WriteLine(faktN/faktK);   
                
	}
        
       
    }
}

