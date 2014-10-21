using System;

class Cinema
{
    static void Main()
    {
        string type = Console.ReadLine();
        double rows = double.Parse(Console.ReadLine());
        double columns = double.Parse(Console.ReadLine());
        double income = 0;
        double people = rows * columns;
        if (type =="Premiere")
        {
           income =  12.00 * people;
           Console.WriteLine("{0:0.00} leva",income);
        }
        else if (type == "Normal")
        {
            income = 7.50 * people;
            Console.WriteLine("{0:0.00} leva",income);
        }
        else if (type == "Discount")
        {
            income = 5.00 * people;
            Console.WriteLine("{0:0.00} leva",income);
        }
        

    }
}

