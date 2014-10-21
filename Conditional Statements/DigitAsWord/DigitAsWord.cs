using System;


class DigitAsWord
{
    static void Main()
    {
        string digit = Convert.ToString(Console.ReadLine());
        switch (digit)
        {
            case "2":
        Console.WriteLine("two");
                break;
            case "1":
                Console.WriteLine("one");
                break;
            case "0":
                Console.WriteLine("zero");
                break;
            case "5":
                Console.WriteLine("five");
                break;
            case "9":
                Console.WriteLine("nine");
                break;
            default:
                {
                    Console.WriteLine("not a digit");
                }
                break;

        }
    }
}

