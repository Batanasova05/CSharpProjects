﻿using System;


class CheckBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
     
        bool isOne = (n & (1 << p)) > 0;
        {
            Console.WriteLine(isOne);
        }
    }
}

