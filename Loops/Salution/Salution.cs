﻿using System;

class Salution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++)

			{
			 for (int col = 1; col <= row; col++)
			{
			 Console.Write("{0}", col);
			}
             Console.WriteLine();
			}

        
    }
}
