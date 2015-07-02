using System;

class FloatOrDouble
{
    static void Main()
    {
        /*Which of the following values can be assigned to a variable 
         of type float and which to a variable of type double: 
         34.567839023, 12.345, 8923.1234857, 3456.091?*/

        double numA = 34.567839023;
        float numB = 12.345F;
        double numC = 8923.1234857;
        float numD = 3456.091F;

        Console.WriteLine(numA + "\n" + numB + "\n" + numC + "\n" + numD);
    }
}
