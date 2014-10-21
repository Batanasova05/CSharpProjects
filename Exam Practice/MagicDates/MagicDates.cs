using System;

class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magic = int.Parse(Console.ReadLine());
        bool hasAnswer = false;
        string date;
        int tempWeight;


        for (int year = startYear; year <= endYear; year++)
        {
            for (int month = 1; month <= 12; month++)
            {
                for (int days = 1; days <= 31; days++)
                {
                    tempWeight = 0;
                    if ((!DateTime.IsLeapYear(year) && month == 2 && days > 28) ||
                        ((DateTime.IsLeapYear(year) && month == 2 && days > 29)) ||
                        (days == 31 && (month == 4 || month == 6 || month == 9 || month == 11)))
                        continue;
                    else
                    {
                        date = "" + days + month + year;
                        for (int i = 0; i < date.Length; i++)
                        {
                            int a = int.Parse(date[i].ToString());
                            for (int j = i + 1; j < date.Length; j++)
                            {
                                int b = int.Parse(date[j].ToString());
                                tempWeight += a * b;

                            }
                        }
                        if (tempWeight == magic)
                        {
                            DateTime print = new DateTime(year, month, days);
                            Console.WriteLine(print.ToString("dd-MM-yyyy"));
                            hasAnswer = true;
                        }
             
                    }
                }
            }

        }
        if (!hasAnswer) 
        {
            Console.WriteLine("No");
        }
    }
}

