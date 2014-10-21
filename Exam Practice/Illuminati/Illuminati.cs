using System;

class Illuminati
{
    static void Main()
    {
        
        {
        string input = Console.ReadLine().ToUpper();
        int sum = 0;
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            char character = input[i];
            if (character == 65 || character == 69 || character == 73 || character == 79 || character == 85)
            {
                count++;
                sum += character;

            }
        }
        Console.WriteLine(count);
        Console.WriteLine(sum);
    }
        }

    }
}

