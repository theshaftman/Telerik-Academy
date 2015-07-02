using System;

class RandomInGivenRange
{
    /*	Write a program that enters 3 integers n, min and max 
    (min = max) and prints n random numbers in the range [min...max].*/

    static void Main()
    {
        Console.Write("Write \"n\": ");
        string strN = Console.ReadLine();
        Console.Write("Write \"min\": ");
        string strMin = Console.ReadLine();
        Console.Write("Write \"max\": ");
        string strMax = Console.ReadLine();

        try
        {
            int n = int.Parse(strN);
            int min = int.Parse(strMin);
            int max = int.Parse(strMax);

            Random randomGenerator = new Random();

            Console.Write("Random numbers: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", randomGenerator.Next(min, max + 1));
            }

            Console.WriteLine("\n");
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Write INT numbers!\n");
        }

        Main();
    }
}
