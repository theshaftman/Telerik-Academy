using System;

class ThirdDigit7
{
    //Write an expression that checks for given integer if its third digit from right-to-left is 7

    static void Main()
    {
        Console.WriteLine("    n      Third Digit 7?");
        IsThirdDigit7(5);
        IsThirdDigit7(701);
        IsThirdDigit7(9703);
        IsThirdDigit7(877);
        IsThirdDigit7(777877);
        IsThirdDigit7(9999799);
    }

    static void IsThirdDigit7(int number)
    {
        string numStr = number.ToString();
        bool isDigit7 = false;

        try
        {
            char strChar = (char)numStr[numStr.Length - 3];

            if (strChar == '7')
            {
                isDigit7 = true;
            }
        }
        catch (Exception) { }

        Console.WriteLine("{0,8} {1,11}", numStr, isDigit7);
    }
}
