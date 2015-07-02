using System;

class QuotesInStrings
{
    static void Main()
    {
        string strA = "The \"use\" of quotations causes difficulties.";
        string strB = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("{0}\n{1}", strA, strB);
    }
}
