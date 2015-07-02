using System;

class BeerTime
{
    /*	A beer time is after 1:00 PM and before 3:00 AM.
	Write a program that enters a time in format “hh:mm tt” 
    (an hour in range [01...12], a minute in range [00…59] 
    and AM / PM designator) and prints beer time or non-beer time
    according to the definition above or invalid time if 
    the time cannot be parsed. */

    static void Main()
    {
        Console.Write("Write the date(hh:mm tt): ");
        string timeStr = Console.ReadLine();

        try
        {
            string[] amPmDevider = timeStr.Split(' ');
            string[] hourMinutesDevider = amPmDevider[0].Split(':');

            string hours = hourMinutesDevider[0];
            string minutes = hourMinutesDevider[1];
            string amPm = amPmDevider[1];
            int numbers;

            if (int.TryParse(hours, out numbers) &&
                int.TryParse(minutes, out numbers))
            {
                int intHours = int.Parse(hours);
                int intMinutes = int.Parse(minutes);

                if (intHours >= 0 && intHours <= 12 &&
                    intMinutes >= 0 && intMinutes <= 59)
                {
                    string setTime = "01/01/2015 " + hours + ":" + minutes + " " + amPm;
                    DateTime time = DateTime.Parse(setTime);

                    DateTime beerTime1 = new DateTime(2015, 1, 1, 13, 0, 0);
                    DateTime beerTime2 = new DateTime(2015, 1, 1, 3, 0, 0);
                    int resultA = DateTime.Compare(time, beerTime1);
                    int resultB = DateTime.Compare(time, beerTime2);

                    if ((resultA >= 0 && resultB >= 0) || (resultA <= 0) && (resultB < 0))
                    {
                        Console.WriteLine("beer time\n");
                    }
                    else
                    {
                        Console.WriteLine("non-beer time\n");
                    }
                }
                else
                {
                    Console.WriteLine("Try again[0-12 hours][0-59 minutes][am/pm]!\n");
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error!\n");
        }

        Main();
    }
}
