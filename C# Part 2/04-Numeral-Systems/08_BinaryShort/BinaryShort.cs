namespace _08_BinaryShort
{
    using System;

    class BinaryShort
    {
        static void Main()
        {
            Console.Write("Write a Short type number: ");
            short shortNum = short.Parse(Console.ReadLine());

            string bin = Convert.ToString(shortNum, 2).PadLeft(16, '0');
            Console.WriteLine("{0}", bin);
        }
    }
}
