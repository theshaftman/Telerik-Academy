namespace _06_BinaryToHexadecimal
{
    using System;

    class BinaryToHexadecimal
    {
        static void Main()
        {
            Console.Write("Write a Binary number: ");
            string bin = Console.ReadLine();

            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] != '0' && bin[i] != '1')
                {
                    Console.Write("Error! Write a Binary number!");

                    return;
                }
            }

            int dec = Convert.ToInt32(bin, 2);
            string hex = Convert.ToString(dec, 16).ToUpper();
            Console.WriteLine("Hexadecimal = {0}", hex);
        }
    }
}
