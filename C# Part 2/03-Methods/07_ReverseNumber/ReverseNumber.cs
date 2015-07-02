namespace _07_ReverseNumber
{
    using System;

    class ReverseNumber
    {
        /*	Write a method that reverses the digits of given decimal number.*/

        static void Main()
        {
            Console.Write("Write a Decimal number: ");
            string str = Console.ReadLine();
            decimal decimals;

            if (decimal.TryParse(str, out decimals))
            {
                Console.WriteLine("{0}\n", Reverse(str));
            }
            else
            {
                Console.WriteLine("Error! Write a Decimal!\n");
            }

            Main();
        }

        static decimal Reverse(string str)
        {
            string strResult = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                strResult += str[i];
            }

            decimal result = decimal.Parse(strResult);

            return result;
        }
    }
}
