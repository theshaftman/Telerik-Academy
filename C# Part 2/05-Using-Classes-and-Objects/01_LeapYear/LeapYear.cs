namespace _01_LeapYear
{
    using System;

    class LeapYear
    {
        /*	Write a program that reads a year from the console and checks whether it is a leap one.
        	Use System.DateTime.*/

        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(num, 1, 1);
            int year = date.Year;
            bool leap = false;

            if (year % 4 == 0 && year % 100 != 0)
            {
                leap = true;
            }
            else if (year % 4 == 0 && year % 100 == 0)
            {
                if (year % 100 == 0 && year % 400 == 0)
                {
                    leap = true;
                }
            }

            Console.WriteLine("Is {0} leap year? {1}\n", year, leap);

            Main();
        }
    }
}
