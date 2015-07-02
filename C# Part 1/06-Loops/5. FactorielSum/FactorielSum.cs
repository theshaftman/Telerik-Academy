using System;

class FactorielSum
{
    /*	Write a program that, for a given two integer numbers n and x,
    calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.*/

    static void Main()
    {
        Console.Write("Write \"N\": ");
        string strN = Console.ReadLine();
        Console.Write("Write \"X\": ");
        string strX = Console.ReadLine();

        try
        {
            int n = int.Parse(strN);
            int x = int.Parse(strX);

            double sum = 1d;

            for (int i = 1; i <= n; i++)
            {
                double j = Factoriel(i) / Math.Pow(x, i);
                sum += j;
            }

            Console.WriteLine("Factoriel sum S = {0:F5}\n", sum);
            
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Try again!\n");
        }

        Main();
    }

    static double Factoriel(int number)
    {
        double result = 1d;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}
