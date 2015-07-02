using System;

class NumbersFrom1ToN
{
    /*	Write a program that reads an integer number n from the console 
    and prints all the numbers in the interval [1..n], each on a single line.*/

    static void Main()
    {
        Console.Write("\nWrite \"N\": ");
        string strN = Console.ReadLine();

        try
        {
            int n = int.Parse(strN);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            Main();
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Try with INT number!");

            Main();
        }
    }
}
