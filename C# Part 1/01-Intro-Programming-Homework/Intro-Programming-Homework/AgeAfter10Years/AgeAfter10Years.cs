using System;

class AgeAfter10Years
{
    static void Main()
    {
        int birthMonth = 10;
        int birthYear = 1989;
        DateTime date = DateTime.Now;

        int yearNow = date.Year;
        int monthNow = date.Month;
        int myAge = 0;

        if (birthMonth > monthNow)
        {
            myAge = (yearNow - birthYear) - 1;
        }
        else
        {
            myAge = yearNow - birthYear;
        }

        int after10Years = myAge + 10;

        Console.WriteLine("Now you are: {0}", myAge);
        Console.WriteLine("After 10 years you will be: {0}", after10Years);
    }
}
