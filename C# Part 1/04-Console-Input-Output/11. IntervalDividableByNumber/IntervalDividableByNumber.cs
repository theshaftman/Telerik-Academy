using System;

class IntervalDividableByNumber
{
    /*	Write a program that reads two positive integer numbers and prints 
    how many numbers p exist between them such that the reminder of the 
    division by 5 is 0.*/

    static void Main()
    {
        Console.Write("\nWrite START: ");
        string startStr = Console.ReadLine();
        Console.Write("Write END: ");
        string endStr = Console.ReadLine();

        try
        {
            int start = int.Parse(startStr);
            int end = int.Parse(endStr);
            int j = 0;

            Console.Write("(");

            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    j++;
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine(") {0} times", j);

            Main();
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Try with INT numbers!");

            Main();
        }
    }
}
