namespace _03_DayOfWeek
{
    using System;

    class DayOfWeek
    {
        /*	Write a program that prints to the console which day of the week is today.
        	Use System.DateTime.*/

        static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Today it`s {0}", now.DayOfWeek);
        }
    }
}
