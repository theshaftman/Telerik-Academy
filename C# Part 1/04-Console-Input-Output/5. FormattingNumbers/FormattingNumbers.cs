using System;

class FormattingNumbers
{
    /*	Write a program that reads 3 numbers: 
        o	integer a (0 <= a <= 500)
        o	floating-point b 
        o	floating-point c 
    	The program then prints them in 4 virtual columns on the console. 
     Each column should have a width of 10 characters. 
        o	The number a should be printed in hexadecimal, left aligned
        o	Then the number a should be printed in binary form, padded with zeroes
        o	The number b should be printed with 2 digits after the decimal point, right aligned
        o	The number c should be printed with 3 digits after the decimal point, left aligned*/

    static void Main()
    {
        Console.Write("\nWrite INT \"A\": ");
        string intA = Console.ReadLine();
        Console.Write("Write Floating-point \"B\": ");
        string floatB = Console.ReadLine();
        Console.Write("Write Floating-point\"C\": ");
        string floatC = Console.ReadLine();

        try
        {
            int a = int.Parse(intA);
            float b = float.Parse(floatB);
            float c = float.Parse(floatC);

            if ((a >= 0) && (a <= 500))
            {
                string strHex = Convert.ToString(a, 16).ToUpper();
                string strBin = Convert.ToString(a, 2);

                if (strBin.Length < 10)
                {
                    int strAdded = 10 - strBin.Length;

                    while (strAdded > 0)
                    {
                        strBin = "0" + strBin;
                        strAdded--;
                    }
                }

                Console.WriteLine("{0,-10}|{1,10}|{2,10:F2}|{3,-10:F3}", strHex, strBin, b, c);
            }

            Main();
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Try again!");

            Main();
        }
    }
}
