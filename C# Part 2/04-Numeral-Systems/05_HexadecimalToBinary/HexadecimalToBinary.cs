namespace _05_HexadecimalToBinary
{
    using System;

    class HexadecimalToBinary
    {
        static void Main()
        {
            Console.Write("Write Hexadecimal number: ");
            string hex = Console.ReadLine();

            int dec = Convert.ToInt32(hex, 16);
            string bin = Convert.ToString(dec, 2);

            Console.WriteLine("Binary = {0}", bin);
        }
    }
}
