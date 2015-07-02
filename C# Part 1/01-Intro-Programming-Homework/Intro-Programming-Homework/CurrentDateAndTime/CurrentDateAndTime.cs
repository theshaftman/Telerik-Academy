using System;

class CurrentDateAndTime
{
    static void Main()
    {
        DateTime dateNow = DateTime.Now;
        DateTime dateUTC = DateTime.UtcNow;

        Console.WriteLine(dateNow);
        Console.WriteLine(dateUTC);
    }
}
