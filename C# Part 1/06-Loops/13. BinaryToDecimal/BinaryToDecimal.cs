using System;

class BinaryToDecimal
{
    /*	Using loops write a program that converts a binary 
    integer number to its decimal form.
    	The input is entered as string. The output should be 
    a variable of type long.
    	Do not use the built-in .NET functionality.*/

    static void Main()
    {
        Console.Write("Write binary: ");
        string binary = Console.ReadLine();

        try
        {
            int[] nums = new int[binary.Length];
            int num = 1;
            nums[0] = 1;
            long dec = 0;

            for (int j = 1; j < nums.Length; j++)
            {
                nums[j] = num * 2;
                num = nums[j];
            }

            for (int i = binary.Length; i > 0; i--)
            {
                if (binary[i - 1].ToString() == "1")
                {
                    dec += nums[binary.Length - i];
                }
                else if (binary[i - 1].ToString() == "0")
                {

                }
                else
                {
                    Console.WriteLine("Error! Try again!\n");

                    Main();
                }
            }

            Console.WriteLine("Decimal = {0}\n", dec);
        }
        catch (Exception)
        {
            Console.WriteLine("Error! Try again!\n");
        }

        Main();
    }
}
