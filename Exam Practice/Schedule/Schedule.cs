using System;
using System.Globalization;
using System.Threading;

class Schedule
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-Us");
        
        int startHour = int.Parse(Console.ReadLine());
        int startMinutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int durationHours = int.Parse (Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());

        if (partOfDay == "PM")
	{
		 startHour+= 12;
            if (startHour == 24)
	{
		 startHour = 0;
	}
	}
        DateTime startTime = new DateTime (2014, 02, 02, startHour,startMinutes,0);
        DateTime endTime = startTime.AddHours(durationHours).AddMinutes(durationMinutes);
        Console.WriteLine("{0:hh:mm:tt}", endTime);
    }
}

