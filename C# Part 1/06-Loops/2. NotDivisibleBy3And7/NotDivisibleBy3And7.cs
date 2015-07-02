using System;

class NotDivisibleBy3And7
{
    /*	Write a program that enters from the console a positive integer n 
    and prints all the numbers from 1 to n not divisible by 3 and 7, 
    on a single line, separated by a space.*/

    static void Main()
    {
        Console.Write("Write \"N\": ");
        string str = Console.ReadLine();

        try
        {
            int number = int.Parse(str);

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write("{0} ", i);
                }
            }

            Console.WriteLine("\n");
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Write INT number!\n");
        }

        Main();
    }
}
