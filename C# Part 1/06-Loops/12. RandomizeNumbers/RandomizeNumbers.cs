using System;

class RandomizeNumbers
{
    /*	Write a program that enters in integer n and prints 
    the numbers 1, 2, …, n in random order.*/

    static void Main()
    {
        Console.Write("Write \"n\": ");
        string strN = Console.ReadLine();

        try
        {
            int n = int.Parse(strN);
            Random randomGenerator = new Random();
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = randomGenerator.Next(n + 1);
            }

            Console.WriteLine("Random numbers: ");
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.Write("{0} ", numbers[j]);
            }

            Console.WriteLine("\n");
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Write an INT number!\n");
        }

        Main();
    }
}
