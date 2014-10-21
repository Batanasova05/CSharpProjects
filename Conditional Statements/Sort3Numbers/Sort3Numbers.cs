using System;

class Sort3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if ((a>b)&& (a>c))
        {
                if (b>c)
                {
                    Console.WriteLine("The numbers sequence is: {0} {1} {2}", a,b,c);
                }
                else
                {
                    Console.WriteLine("The numbers sequence is : {0} {1} {2}", a,c,b);
                }
            }
                else if ((b>a) && (b>c))
{
    if (a>c)
	{
		  Console.WriteLine("The numbers sequence is : {0} {1} {2}",b,a,c);
	}
                else
	{
          Console.WriteLine("The numbers sequence is : {0} {1} {2}",b,c,a);
	}
}

else if ((a<c) && (b<c))
	{
        if (a>b)
	{
		 Console.WriteLine("The numbers sequence is : {0} {1} {2}",c,a,b);
	}
        else
	{
            Console.WriteLine("The numbers sequence is : {0} {1} {2}",c,b,a);
	}
		 
	}
            
	
            }
        }
    


