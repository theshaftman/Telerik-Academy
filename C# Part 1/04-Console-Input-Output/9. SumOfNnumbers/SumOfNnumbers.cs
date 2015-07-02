using System;

class SumOfNnumbers
{
    /*	Write a program that enters a number n and after that enters more n numbers 
    and calculates and prints their sum. */

    static void Main()
    {
        Console.Write("\nWrite the number of numbers: ");
        string numberN = Console.ReadLine();

        try
        {
            int n = int.Parse(numberN);
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Write number \"{0}\": ", i + 1);
                string str = Console.ReadLine();

                try
                {
                    double number = double.Parse(str);
                    sum += number;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error! Try with a NUMBER!");

                    Main();
                }
            }

            Console.WriteLine("Sum: {0:0.###}", sum);

            Main();
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Write a Number!");

            Main();
        }
    }
}
