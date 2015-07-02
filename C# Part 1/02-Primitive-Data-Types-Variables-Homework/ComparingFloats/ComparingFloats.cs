using System;

class ComparingFloats
{
    static void Main()
    {
        float numberA = 5.3f;
        float numberB = 6.01f;
        double numA = 5.00000001;
        double numB = 5.00000003;
        decimal numbA = 5.00000005m;
        decimal numbB = 5.00000001m;
        decimal number1 = -0.0000007m;
        decimal number2 = 0.00000007m;
        decimal firstNumber = -4.999999m;
        decimal secondNumber = -4.999998m;

        Console.WriteLine("{0}, Difference = {1}", 
            Compare((decimal)numberA, (decimal)numberB),
            Difference((decimal)numberA, (decimal)numberB)); 
        Console.WriteLine("{0}, Difference = {1}",
             Compare((decimal)numA, (decimal)numB),
             Difference((decimal)numA, (decimal)numB));
        Console.WriteLine("{0}, Difference = {1}",
            Compare((decimal)numbA, (decimal)numbB),
            Difference((decimal)numbA, (decimal)numbB));
        Console.WriteLine("{0}, Difference = {1}",
            Compare((decimal)number1, (decimal)number2),
            Difference((decimal)number1, (decimal)number2));
        Console.WriteLine("{0}, Difference = {1}",
            Compare((decimal)firstNumber, (decimal)secondNumber),
            Difference((decimal)firstNumber, (decimal)secondNumber));
    }

    static bool Compare(decimal numberA, decimal numberB)
    {
        bool result = false;

        if (Math.Abs((decimal)numberA - (decimal)numberB) < 0.000001m)
        {
            result = true;
        }

        return result;
    }

    static decimal Difference(decimal numberA, decimal numberB)
    {
        decimal difference;

        if ((decimal)numberA > (decimal)numberB)
        {
            difference = (decimal)numberA - (decimal)numberB;
        }
        else
        {
            difference = (decimal)numberB - (decimal)numberA;
        }

        return difference;
    }
}
