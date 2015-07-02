using System;

class FourDigitNumber
{
    /*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) 
     and performs the following: 
        o	Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4)
        o	Prints on the console the number in reversed order: dcba (in our example 1102)
        o	Puts the last digit in the first position: dabc (in our example 1201)
        o	Exchanges the second and the third digits: acbd (in our example 2101)*/

    static void Main()
    {
        Console.WriteLine("  n  sum reversed  dabc  acbd");

        DigitNumber(2011);
        DigitNumber(3333);
        DigitNumber(9876);
    }

    static void DigitNumber(int number)
    {
        string str = number.ToString();

        if (str.Length == 4)
        {
            int sum = 0;
            string reversed = str[3].ToString() + str[2].ToString() + str[1].ToString() + str[0].ToString();
            string dabc = str[3].ToString() + str[0].ToString() + str[1].ToString() + str[2].ToString();
            string acbd = str[0].ToString() + str[2].ToString() + str[1].ToString() + str[3].ToString();

            for (int i = 0; i < str.Length; i++)
            {
                string chr = str[i].ToString();
                sum += Convert.ToInt32(chr);
            }

            Console.WriteLine("{0,4} {1,3} {2,8} {3,5} {4,5}", number, sum, reversed, dabc, acbd);
        }
        else
        {
            Console.WriteLine("Error! Write a number with 4 digits!");
        }
    }
}
