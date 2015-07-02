using System;

class HexadecimalToDecimal
{
    /*	Using loops write a program that converts a hexadecimal 
    integer number to its decimal form.
    	The input is entered as string. The output should be a 
    variable of type long.
    	Do not use the built-in .NET functionality.*/

    static void Main()
    {
        Console.Write("Write hexadecimal: ");
        string hex = Console.ReadLine();

        int numbers;
        int[] hexNum = new int[hex.Length];

        for (int k = 0; k < hex.Length; k++)
        {
            if (int.TryParse(hex[k].ToString(), out numbers))
            {
                hexNum[k] = int.Parse(hex[k].ToString());
            }
            else if (hex[k].ToString().ToUpper() == "A")
            {
                hexNum[k] = 10;
            }
            else if (hex[k].ToString().ToUpper() == "B")
            {
                hexNum[k] = 11;
            }
            else if (hex[k].ToString().ToUpper() == "C")
            {
                hexNum[k] = 12;
            }
            else if (hex[k].ToString().ToUpper() == "D")
            {
                hexNum[k] = 13;
            }
            else if (hex[k].ToString().ToUpper() == "E")
            {
                hexNum[k] = 14;
            }
            else if (hex[k].ToString().ToUpper() == "F")
            {
                hexNum[k] = 15;
            }
            else
            {
                Console.WriteLine("Error! Write HEX number!\n");

                Main();
            }
        }

        double dec = 0;
        int j = 0;

        for (int i = hexNum.Length; i > 0; i--)
        {
            dec += double.Parse(hexNum[i - 1].ToString()) * Math.Pow(16, j);
            j++;
        }

        long result = long.Parse(dec.ToString());
        Console.WriteLine("Decimal = {0}\n", result);
        Main();
    }
}
