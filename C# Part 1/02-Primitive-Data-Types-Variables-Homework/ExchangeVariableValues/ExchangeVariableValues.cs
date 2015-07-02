using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int numA = 5;
        int numB = 10;

        Console.WriteLine("A = {0}\nB = {1}", numA, numB);

        int numC = numB;
        numB = numA;
        numA = numC;

        Console.WriteLine();
        Console.WriteLine("A = {0}\nB = {1}", numA, numB);
    }
}
