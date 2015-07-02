using System;

class CheckBitAtPosition
{
    /*Write a Boolean expression that returns if the bit at position p 
     (counting from 0, starting from the right) in given integer number n, has value of 1*/

    static void Main()
    {
        Console.WriteLine("({0,3}) ({1}) ({2}) ({3})", "n", "binary representation", "p", "bit at p == 1");

        Check(5, 2);
        Check(0, 9);
        Check(15, 1);
        Check(5343, 7);
        Check(62241, 11);
    }

    static void Check(int number, int position)
    {
        string bin = Convert.ToString(number, 2);
        bool isOne = false;

        if (bin.Length < 16)
        {
            int zeroAdded = 16 - bin.Length;

            while (zeroAdded > 0)
            {
                bin = "0" + bin;
                zeroAdded--;
            }
        }

        if (bin[bin.Length - (position + 1)] == '1')
        {
            isOne = true;
        }

        Console.WriteLine("{0,5} {1,21} {2,4} {3,10}", number, bin, position, isOne);
    }
}
