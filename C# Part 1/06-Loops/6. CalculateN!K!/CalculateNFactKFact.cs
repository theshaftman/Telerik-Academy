using System;

class CalculateNFactKFact
{
    /*	Write a program that calculates n! / k! for given n and k 
    (1 < k < n < 100).*/

    static void Main()
    {
        Console.Write("Write \"N\": ");
        string strN = Console.ReadLine();
        Console.Write("Write \"K\": ");
        string strK = Console.ReadLine();

        try
        {
            int n = int.Parse(strN);
            int k = int.Parse(strK);

            if (n > 1 && n < 100 && k > 1 && k < 100 && k < n)
            {
                double result = Factoriel(n) / Factoriel(k);

                Console.WriteLine("N! / K! = {0}\n", result);
            }
            else
            {
                Console.WriteLine("Error! Try again!");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Try again!");
        }

        Main();
    }

    static int Factoriel(int number)
    {
        int fact = 1;

        for (int i = 1; i <= number; i++)
        {
            fact *= i;
        }

        return fact;
    }
}
