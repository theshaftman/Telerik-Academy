using System;

class CalculateGCD
{
    /*	Write a program that calculates the greatest common 
    divisor (GCD) of given two integers a and b.*/

    static void Main()
    {
        Console.Write("Write \"A\": ");
        string strA = Console.ReadLine();
        Console.Write("Write \"B\": ");
        string strB = Console.ReadLine();

        try
        {
            int a = int.Parse(strA);
            int b = int.Parse(strB);
            int gdc = a;
            int gdcResult = b;

            if (a < b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }

            int divisor = (a % b);

            while (divisor != 0)
            {
                gdc = gdcResult;
                gdcResult = divisor;
                divisor = gdc % gdcResult;
            }

            Console.WriteLine("The greatest common divisor of {0} and {1} is {2}\n"
                , a, b, gdcResult);
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Write INT!\n");
        }

        Main();
    }
}
