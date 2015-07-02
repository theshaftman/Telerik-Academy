namespace _11_FormatNumber
{
    using System;

    class FormatNumber
    {
        /*	Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
        percentage and in scientific notation.
        	Format the output aligned right in 15 symbols.*/

        static void Main()
        {
            Console.Write("Write an INT number: ");
            string str = Console.ReadLine();
            int numbers;

            if (int.TryParse(str, out numbers))
            {
                int number = int.Parse(str);

                Console.WriteLine("{0,15:D} -> Decimal", number);
                Console.WriteLine("{0,15:X} -> Hexadecimal", number);
                Console.WriteLine("{0,15:P} -> Percentage", number / 100.0);
                Console.WriteLine("{0,15:E} -> Scientific notation", number);
            }
            else
            {
                Console.WriteLine("Error! Write an INT!");
            }

            Console.WriteLine();
            Main();
        }
    }
}
