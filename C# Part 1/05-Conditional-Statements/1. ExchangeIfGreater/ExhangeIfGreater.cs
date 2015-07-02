using System;

class ExchangeIfGreater
{
    /*	Write an if-statement that takes two double variables a and b and exchanges 
    their values if the first one is greater than the second one. As a result print 
    the values a and b, separated by a space.*/

    static void Main()
    {
        Console.Write("Write \"A\": ");
        string strA = Console.ReadLine();
        Console.Write("Write \"B\": ");
        string strB = Console.ReadLine();

        try
        {
            double numA = double.Parse(strA);
            double numB = double.Parse(strB);
            double numC;

            if (numA >= numB)
            {
                numC = numA;
                numA = numB;
                numB = numC;
            }

            Console.WriteLine("\nResult:\n{0} {1}\n", numA, numB);
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Try with a Double Number!!!");
        }

        Main();
    }
}
