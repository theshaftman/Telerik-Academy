using System;

class NumberComparer
{
    /*	Write a program that gets two numbers from the console and prints the greater of them 
    without if statement.*/

    static void Main()
    {
        Console.Write("Write \"A\": ");
        string strA = Console.ReadLine();
        Console.Write("Write \"B\": ");
        string strB = Console.ReadLine();

        try
        {
            double a = double.Parse(strA);
            double b = double.Parse(strB);

            double biggest = (a >= b) ? a : b;
            Console.WriteLine("Greater: {0}\n", biggest);

            Main();
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Try with a number!\n");

            Main();
        }
    }
}
