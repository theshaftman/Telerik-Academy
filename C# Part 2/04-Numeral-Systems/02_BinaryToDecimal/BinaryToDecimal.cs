namespace _02_BinaryToDecimal
{
    using System;

    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Write Binary number: ");
            string bin = Console.ReadLine();

            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] != '1' && bin[i] != '0')
                {
                    Console.WriteLine("Error! Write Binary!");

                    return;
                }
            }

            int dec = Convert.ToInt32(bin, 2);
            Console.WriteLine("Decimal = {0}", dec);
        }
    }
}
