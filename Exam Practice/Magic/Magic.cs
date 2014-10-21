using System;


class Magic
{
    static void Main(string[] args)
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        for (int a = 0; a < 8; a++)
        {
            for (int b = 0; b < 8; b++)
            {
                for (int c = 0; c < 8; c++)
                {
                    int abc = a * 100 + b * 10 + c;
                    for (int d = 0; d < 8; d++)
                    {
                        for (int e = 0; e < 8; e++)
                        {
                            for (int f = 0; f < 8; f++)
                            {
                                int def = d * 100 + e * 10 + f;
                                for (int g = 0; g < 8; g++)
                                {
                                    for (int h = 0; h < 8; h++)
                                    {
                                        for (int i = 0; i < 8; i++)
                                        {
                                            int ghi = g * 100 + h * 10 + i;

                                            if (ghi - def == diff && def - abc == diff)
                                            {
                                                if (a + b + c + d + e + f + g + h + i == sum)
                                                {
                                                    if (abc <= def && def <= ghi)
                                                    {
                                                        Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}
        
    

