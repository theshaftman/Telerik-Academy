using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxSumAverage
{
    /*	Write a program that reads from the console a sequence 
    of n integer numbers and returns the minimal, the maximal number, 
    the sum and the average of all numbers (displayed with 2 digits 
    after the decimal point).
    	The input starts by the number n (alone in a line) followed by 
    n lines, each holding an integer number.*/

    static void Main()
    {
        Console.Write("Write the number of numbers: ");
        string str = Console.ReadLine();
        int numbers;

        if (int.TryParse(str, out numbers) && int.Parse(str) > 0)
        {
            int number = int.Parse(str);
            int[] intNumbers = new int[number];

            for (int i = 0; i < number; i++)
            {
                Console.Write("Write a number {0}: ", i + 1);
                string strNum = Console.ReadLine();

                try
                {
                    int num = int.Parse(strNum);
                    intNumbers[i] = num;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error! Write INT!");

                    Main();
                }
            }

            Console.WriteLine("Min: {0}\nMax: {1}\nSum: {2}\nAverage: {3:0.00}", 
                intNumbers.Min(), intNumbers.Max(), 
                intNumbers.Sum(), intNumbers.Average());
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Error! Write a INT positive number!");
        }

        Main();
    }
}
