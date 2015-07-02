using System;
using System.Collections.Generic;

class DeimalToBinary
{
    /*	Using loops write a program that converts an integer 
    number to its binary representation.
    	The input is entered as long. The output should be a 
    variable of type string.
    	Do not use the built-in .NET functionality.*/

    static void Main()
    {
        Console.Write("Write decimal: ");
        string strDec = Console.ReadLine();

        try
        {
            long number = long.Parse(strDec);
            List<string> binaryStr = new List<string>();
            string binary = "";

            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    binaryStr.Add("0");
                }
                else
                {
                    binaryStr.Add("1");
                }
                number /= 2;
            }

            for (int i = binaryStr.Count; i > 0; i--)
            {
                binary += binaryStr[i - 1];
            }

            Console.WriteLine("Binary = {0}\n", binary);
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Try again with INT number!");
        }

        Main();
    }
}
