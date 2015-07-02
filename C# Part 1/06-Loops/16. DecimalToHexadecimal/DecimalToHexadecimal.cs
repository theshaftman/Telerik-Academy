using System;

class DecimalToHexadecimal
{
    /*	Using loops write a program that converts an integer 
    number to its hexadecimal representation.
    	The input is entered as long. The output should be a
    variable of type string.
    	Do not use the built-in .NET functionality.*/

    static void Main()
    {
        Console.Write("Enter an INT number: ");
        string str = Console.ReadLine();

        try
        {
            long number = long.Parse(str);
            string hex = "";
            string result = "";

            while (number > 0)
            {
                int index = 0;
                char hexValue = '0';
                long remainder = number % 16;
                if (remainder > 9)
                {
                    switch (remainder)
                    {
                        case 10: hexValue = 'A';
                            break;
                        case 11: hexValue = 'B';
                            break;
                        case 12: hexValue = 'C';
                            break;
                        case 13: hexValue = 'D';
                            break;
                        case 14: hexValue = 'E';
                            break;
                        case 15: hexValue = 'F';
                            break;
                    }

                    result += hexValue;
                }
                else
                {
                    result += remainder;
                }

                number /= 16;
                index++;
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                hex += result[i];
            }

            Console.WriteLine("Hexadecimal = {0}\n", hex);
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Write INT!\n");
        }

        Main();
    }
}
