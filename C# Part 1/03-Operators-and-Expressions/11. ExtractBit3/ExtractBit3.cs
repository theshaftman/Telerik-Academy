using System;

class ExtractBit3
{
    /*Using bitwise operators, write an expression for finding the value of 
     the bit #3 of a given unsigned integer*/

    static void Main()
    {
        int[] n = { 5, 0, 15, 5343, 62241 };

        Console.WriteLine("({0,3}) ({1}) ({2})", "n", "binary representation", "bit #3");

        for (int i = 0; i < n.Length; i++)
        {
            string bin = Convert.ToString(n[i], 2);

            if (bin.Length < 16)
            {
                int zeroAdded = 16 - bin.Length;

                while (zeroAdded > 0)
                {
                    bin = "0" + bin;
                    zeroAdded--;
                }
            }

            Console.WriteLine("{0,5} {1,21} {2,6}", n[i], bin, bin[bin.Length - 4]);
        }
    }
}
