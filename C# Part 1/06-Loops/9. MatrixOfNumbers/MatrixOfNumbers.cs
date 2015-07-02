using System;

class MatrixOfNumbers
{
    /*	Write a program that reads from the console a positive 
    integer number n (1 = n = 20) and prints a matrix like in 
    the examples below. Use two nested loops.*/

    static void Main()
    {
        Console.Write("Write \"n\": ");
        string strN = Console.ReadLine();

        try
        {
            int n = int.Parse(strN);

            if (n >= 0 && n <= 20)
            {
                Console.WriteLine("Matrix");
                int begin = 1;

                for (int row = 1; row <= n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write("{0, 2}", row + col);

                        begin++;
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error! \"n\" should be between 0 and 20!\n");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Try with an INT Number!\n");
        }

        Main();
    }
}
