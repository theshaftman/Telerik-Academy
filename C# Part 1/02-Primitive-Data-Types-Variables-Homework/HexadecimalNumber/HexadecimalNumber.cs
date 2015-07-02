using System;

class HexadecimalNumber
{
    static void Main()
    {
        int numbDecim = 254;
        string numbHex = Convert.ToString(numbDecim, 16).ToUpper();

        Console.WriteLine(numbHex);
    }
}
