using System;
  class Example
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n+1; row++)
            {
                for (int col = 0; col < n-1; col++)
                {
                    Console.Write("{0} ",n);
                }
                Console.WriteLine();
            }
        }
    }
