using System;

class FruitMarket
{
    static void Main()
    {
        string weekDay = Console.ReadLine();
        double sum = 0;
        for (int i = 0; i < 3; i++)
        {
            double tempQuantity = double.Parse(Console.ReadLine());
            string tempProduct = Console.ReadLine();
            double price = 0;
            bool isFruit = false;
            switch (tempProduct)
            {
                case "banana":
                    {
                        price = 1.80;
                        isFruit = true;
                    }
                    break;
                case "cucumber":
                    
                        price = 2.75;
                    break;
                case "tomato":

                    price = 3.20;                   
                    break;
                case "orange":
                    {
                        price = 1.60;
                        isFruit = true;
                    }
                    break;
                case "apple":
                    {
                        price = 0.86;
                        isFruit = true;
                    }
                    break;
             }
            double value = price * tempQuantity;

            switch (weekDay)
            {
                case "Friday":
                    {
                        value = 0.9 * value;
                    }
                    break;
                case "Sunday":
                    
                        value = 0.95 * value;
                    
                    break;
                case "Tuesday":
                    {
                        if (isFruit )
                        {
                            value = 0.8 * value;
                        }
                    }
                    break;

                case "Wednesday":
                    {
                        if (!isFruit )
                        {
                            value = 0.9 * value;
                        }
                    }
                    break;
                case "Thursday":
                    {
                        if (tempProduct == "banana")
                        {
                            value = 0.7 * value;
                        }

                    }
                    break;        
            }
              sum += value;
        }
        Console.WriteLine("{0:f2}",sum);
    }
}

