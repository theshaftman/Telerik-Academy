namespace _06_StringLength
{
    using System;

    class StringLength
    {
        /*	Write a program that reads from the console a string of maximum 20 characters. 
        If the length of the string is less than 20, the rest of the characters should be filled with *.
        	Print the result string into the console.*/

        static void Main()
        {
            Console.Write("Write a string with letters not much than 20 symbols: ");
            string str = Console.ReadLine();
            int maxSymbols = 20;

            if (str.Length <= maxSymbols)
            {
                string result = str;

                result += new string('*', maxSymbols - str.Length);

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error! Write not much than 20 symbols!");
            }

            Console.WriteLine();
            Main();
        }
    }
}
