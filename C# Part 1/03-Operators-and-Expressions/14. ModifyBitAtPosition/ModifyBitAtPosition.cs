using System;

class ModifyBitAtPosition
{
    /*Write a sequence of operators (a few lines of C# code) that modifies n 
     to hold the value v at the position p from the binary representation of n 
     while preserving all other bits in n*/

    static void Main()
    {
        Console.WriteLine("({0,3}) ({1}) ({2}) ({3}) ({4}) ({5})", 
            "n", "binary representation", "p", "v", "binary result", "result");

        Check(5, 2, 0);
        Check(0, 9, 1);
        Check(15, 1, 1);
        Check(5343, 7, 0);
        Check(62241, 11, 0);
    }

    static void Check(int number, int position, int value)
    {
        string bin = Convert.ToString(number, 2);
        string chrValue = value.ToString();

        if (bin.Length < 16)
        {
            int zeroAdded = 16 - bin.Length;

            while (zeroAdded > 0)
            {
                bin = "0" + bin;
                zeroAdded--;
            }
        }

        int pos = bin.Length - (position + 1);
        string fixedBin = bin.Remove(pos, 1).Insert(pos, chrValue);

        Console.WriteLine("{0,5} {1,21} {2,4} {3,3} {4,17} {5,6}", 
            number, bin, position, chrValue, fixedBin, MakeBinDec(fixedBin));
    }

    static long MakeBinDec(string numStr)
    {
        long number = Convert.ToInt64(numStr, 2);

        return number;
    }
}
