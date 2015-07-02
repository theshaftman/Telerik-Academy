namespace _04_HexadecimalToDecimal
{
    using System;

    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Write a Hexadecimal number: ");
            string hex = Console.ReadLine();

            int dec = Convert.ToInt32(hex, 16);
            Console.WriteLine("Decimal = {0}", dec);
        }
    }
}
