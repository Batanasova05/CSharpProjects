using System;




class DivideNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isDivisible = n % 5 == 0 && n % 7 == 0;
        Console.WriteLine(isDivisible);


    }
}
