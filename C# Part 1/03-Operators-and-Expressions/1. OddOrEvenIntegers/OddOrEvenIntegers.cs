using System;

class OddOrEvenIntegers
{
    //Write an expression that checks if given integer is odd or even

    static void Main()
    {
        Console.WriteLine("Odd?");
        Console.WriteLine(OddEven(3));
        Console.WriteLine(OddEven(2));
        Console.WriteLine(OddEven(-2));
        Console.WriteLine(OddEven(-1));
        Console.WriteLine(OddEven(0));
    }

    static bool OddEven(int number)
    {
        bool oddEven = false;

        if (number % 2 != 0)
        {
            oddEven = true;
        }

        return oddEven;
    }
}
