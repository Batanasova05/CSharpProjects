using System;




class OddEven
{
    static void Main()
    {
        int a = 3;
        int b = 2;
        int c = -2;
        int d = -1;
        int e = 0;

        bool oddEven1 = (a % 2 == 1);
        bool oddEven2 = (b % 2 == 1);
        bool oddEven3 = (c % 2 == 1);
        bool oddEven4 = (d % 1 == 0);
        bool oddEven5 = (e % 2 == 1);

        Console.WriteLine("Is number" + " " + a + " " + "odd? " + oddEven1);
        Console.WriteLine("Is number" +" " + b + " "+ "odd? " + oddEven2);
        Console.WriteLine("Is number" + " " + c + " " + "odd? " + oddEven3);
        Console.WriteLine("Is number" + " " + d + " "+ "odd? " + oddEven4);
        Console.WriteLine("Is number" + " " + e + " " + "odd? " + oddEven5);

    }
}

