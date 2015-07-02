using System;

class TrailingZeroesInN
{
    /*	Write a program that calculates with how many zeroes 
    the factorial of a given number n has at its end.*/

    static void Main()
    {
        Console.Write("Enter an INT number: ");
        string str = Console.ReadLine();

        try
        {
            int n = int.Parse(str);
            int counter = 0;
            int divider = 5;

            while (n / divider >= 1)
            {
                counter += n / divider;
                divider *= 5;
            }

            Console.WriteLine("{0}! has {1} trailing zeros\n"
                , n, counter);
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Write an INT number!\n");
        }

        Main();
    }
}
