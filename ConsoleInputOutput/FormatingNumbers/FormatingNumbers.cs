using System;



class FormatingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());


        Console.WriteLine("|{0,-10:X} | {1}| {2,10:####}| {3,-10:#####}", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
     
     

      
    }
}

