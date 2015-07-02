using System;

class ExtractBitFromInteger
{
    //Write an expression that extracts from given integer n the value of given bit at index p

    static void Main()
    {
        Console.WriteLine("({0,3}) ({1}) ({2}) ({3})", "n", "binary representation", "p", "bit at p");

        Check(5, 2);
        Check(0, 9);
        Check(15, 1);
        Check(5343, 7);
        Check(62241, 11);
    }

    static void Check(int number, int position)
    {
        string bin = Convert.ToString(number, 2);

        if (bin.Length < 16)
        {
            int zeroAdded = 16 - bin.Length;

            while (zeroAdded > 0)
            {
                bin = "0" + bin;
                zeroAdded--;
            }
        }

        Console.WriteLine("{0,5} {1,21} {2,4} {3,6}", number, bin, position, bin[bin.Length - (position + 1)]);
    }
}
