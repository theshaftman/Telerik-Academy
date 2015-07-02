using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? numA = null;
        double? numB = null;

        Console.WriteLine("Null value A: {0}\nNull value B: {1}", numA, numB);

        numA += 7;
        numB += 4.5;
        Console.WriteLine("Null value + number A: {0}\nNull value + number B: {1}", numA, numB);

        numA = 7;
        numB = 4.5;
        Console.WriteLine("Number A: {0}\nNumber B: {1}", numA, numB);
    }
}
