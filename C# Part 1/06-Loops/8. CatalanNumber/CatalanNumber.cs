using System;

class CatalanNumber
{
    /*	Write a program to calculate the nth Catalan number 
    by given n (1 < n < 100).*/

    static void Main()
    {
        Console.Write("Write \"N\": ");
        string strN = Console.ReadLine();

        try
        {
            int n = int.Parse(strN);

            if (n >= 0 && n < 100)
            {
                double catalan = Factoriel(2 * n) / 
                    (Factoriel(n + 1) * Factoriel(n));

                Console.WriteLine("Catalan number Cn = {0}\n", catalan);
            }
            else
            {
                Console.WriteLine("Error! \"N\" should be between 0 and 100!\n");
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
        double result = 1d;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}
