namespace _03_DecimalToHexadecimal
{
    using System;

    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Write a Decimal number: ");
            string dec = Console.ReadLine();

            int n = int.Parse(dec);
            string hex = Convert.ToString(n, 16).ToUpper();
            Console.WriteLine("Hexadecimal = {0}", hex);
        }
    }
}
