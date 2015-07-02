using System;

class DigitAsWord
{
    /*	Write a program that asks for a digit (0-9), 
    and depending on the input, shows the digit as a word 
    (in English). 
        o	Print “not a digit” in case of invalid input.
        o	Use a switch statement.*/

    static void Main()
    {
        Console.Write("Write a digit [0-9]: ");
        string str = Console.ReadLine();
        string digit = "";

        switch (str)
        {
            case "0": digit = "zero"; break;
            case "1": digit = "one"; break;
            case "2": digit = "two"; break;
            case "3": digit = "three"; break;
            case "4": digit = "four"; break;
            case "5": digit = "five"; break;
            case "6": digit = "six"; break;
            case "7": digit = "seven"; break;
            case "8": digit = "eight"; break;
            case "9": digit = "nine"; break;
            default: digit = "not a digit"; break;
        }

        Console.WriteLine("Result: {0}\n", digit);
        Main();
    }
}
