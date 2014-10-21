using System;

class BonusScore
{
    static void Main()
    {
        //int score = int.Parse(Console.ReadLine());

        //if ((score >=1)&& (score<=3))
        //{
        //     score*=10;
        //     Console.WriteLine("Your score is : {0}", score);
        //}
        //else if ((score >=4) && (score <=6))
        //{
        //    score *= 100;
        //    Console.WriteLine("Your score is : {0}", score);
        //}
        //else if ((score >=7) && (score <=9))
        //{
        // score *=1000;
        // Console.WriteLine("Your score is : {0}", score);
        //}
        //else  
        //{
        //    Console.WriteLine("Invalid number");
        // }
        int score = int.Parse(Console.ReadLine());

        switch (score)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine(score * 10);

                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine(score * 100);
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine(score * 1000);
                break;


            default:

                Console.WriteLine("Invalid number");

                break;
        }
    }
}
