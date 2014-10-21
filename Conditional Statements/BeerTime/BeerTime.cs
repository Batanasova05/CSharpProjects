using System;

class BeerTime
{
    static void Main()
    {
       
        DateTime timeBeer = new DateTime();
        Console.WriteLine("Enter your time:");
        bool time = DateTime.TryParse(Console.ReadLine(), out timeBeer);
        if (time)
        {
            Console.WriteLine();  
        }



    }
}

