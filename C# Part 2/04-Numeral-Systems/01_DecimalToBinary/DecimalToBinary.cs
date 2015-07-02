namespace _01_DecimalToBinary
{
    using System;

    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Write a Decimal number: ");
            int dec = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(dec, 2);
            Console.WriteLine("Binary = {0}", binary);
        }
    }
}
