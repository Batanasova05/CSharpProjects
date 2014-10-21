using System;

    class Program
    {
        static void Main()
        {
            double h = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double workHours = (d - d * 0.10) * 12;
            double eWork = Math.Floor(workHours * p/100);

            if (eWork>=h)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(Math.Floor(eWork-h));
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine(Math.Floor(eWork-h));
            }
        }
    }

