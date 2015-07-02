using System;

class SumOfFiveNumbers
{
    /*	Write a program that enters 5 numbers (given in a single line, separated by a space),
    calculates and prints their sum.*/

    static void Main()
    {
        Console.Write("\nWrite 5 numbers (separated by space): ");
        string numberStr = Console.ReadLine();
        string[] strNumbers = numberStr.Split(' ');
        double numbers;
        double result = 0;

        if (strNumbers.Length == 5)
        {
            for (int i = 0; i < strNumbers.Length; i++)
            {
                double num = 0;

                if (double.TryParse(strNumbers[i], out numbers))
                {
                    num = double.Parse(strNumbers[i]);
                    result += num;
                }
                else
                {
                    Console.WriteLine("Error! Write NUMBERS!");

                    Main();
                }
            }

            Console.WriteLine(result);

            Main();
        }
        else
        {
            Console.WriteLine("Error! Write FIVE numbers!");

            Main();
        }
    }
}
