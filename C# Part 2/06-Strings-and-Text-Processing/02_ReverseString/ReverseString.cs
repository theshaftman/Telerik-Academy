namespace _02_ReverseString
{
    using System;

    class ReverseString
    {
        /*	Write a program that reads a string, reverses it and prints the result at the console.*/

        static void Main()
        {
            Console.Write("Write a string: ");
            string str = Console.ReadLine();
            string result = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            Console.WriteLine("{0}\n", result);

            Main();
        }
    }
}
