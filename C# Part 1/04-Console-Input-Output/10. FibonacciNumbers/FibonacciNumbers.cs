using System;

class FibonacciNumbers
{
    /*	Write a program that reads a number n and prints on the console the first n members 
    of the Fibonacci sequence (at a single line, separated by comma and space - ,): 
    0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …*/

    static void Main()
    {
        Console.Write("\nWrite \"n\": ");
        string strN = Console.ReadLine();

        try
        {
            int n = int.Parse(strN);
            int a = 0;
            int b = 1;
            int result = 0;

            if (n == 1)
            {
                Console.WriteLine("0");
            }
            else if (n == 2)
            {
                Console.WriteLine("0 1");
            }
            else if (n > 2)
            {
                Console.Write("0 1 ");

                for (int i = 2; i < n; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;

                    Console.Write("{0} ", result);
                }

                Console.WriteLine();
            }

            Main();
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Try with a INT number!");

            Main();
        }
    }
}
