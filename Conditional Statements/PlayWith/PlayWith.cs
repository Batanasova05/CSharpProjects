using System;

class PlayWith
{
    static void Main()
    {
        Console.WriteLine("Please chose a type : \n1 int --> \n2 double --> \n3 string -->");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Please enter a number: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Result {0}", a + 1);break;
            case 2:
                Console.WriteLine("Please enter a number: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Result {0}", b + 1);break;
            case 3:
                Console.WriteLine("Please enter a word:  ");
                string c = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Your word is : {0}*", c);break;

       
        }
    }
    
}

