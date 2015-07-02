using System;

class CombinatoricsNumber
{
    /*	Your task is to write a program that calculates n! / (k! * (n-k)!) 
    for given n and k (1 < k < n < 100).*/

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
                double result = Factoriel(n) / (Factoriel(k) * Factoriel(n - k));

                Console.WriteLine("N! / K! * (N - K)! = {0}\n", result);
            }
            else
            {
                Console.WriteLine("Error! Try again!\n");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Try again!\n");
        }

        Main();
    }

    static double Factoriel(int number)
    {
        double fact = 1d;

        for (int i = 1; i <= number; i++)
        {
            fact *= i;
        }

        return fact;
    }
}
