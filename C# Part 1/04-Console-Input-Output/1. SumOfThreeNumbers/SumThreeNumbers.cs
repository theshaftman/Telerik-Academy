using System;

class SumThreeNumbers
{
    //Write a program that reads 3 real numbers from the console and prints their sum.

    static void Main()
    {
        Console.WriteLine();
        Console.Write("Write \"a\": ");
        string strA = Console.ReadLine();
        Console.Write("Write \"b\": ");
        string strB = Console.ReadLine();
        Console.Write("Write \"c\": ");
        string strC = Console.ReadLine();

        float number;

        if (float.TryParse(strA, out number) && 
            float.TryParse(strB, out number) &&
            float.TryParse(strC, out number))
        {
            float a = float.Parse(strA);
            float b = float.Parse(strB);
            float c = float.Parse(strC);
            float sum = a + b + c;

            Console.WriteLine("Sum: {0}", sum);

            Main();
        }
        else
        {
            Console.WriteLine("Error! Try to enter INT numbers!");

            Main();
        }


    }
}
