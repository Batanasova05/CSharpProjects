using System;


class BitwiseExtract3
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint mask = 1;
      
        {
            Console.WriteLine((mask<<3 & number) == 0 ? "0" : "1");
        }

    }
}

