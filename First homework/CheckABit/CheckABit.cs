using System;




    class CheckABit
    {
        static void Main()
        {
        uint number = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        uint mask = 1;
      
        {
            Console.WriteLine((mask<< p & number) == 0 ? "0" : "1");
        }

    }
        }
    

