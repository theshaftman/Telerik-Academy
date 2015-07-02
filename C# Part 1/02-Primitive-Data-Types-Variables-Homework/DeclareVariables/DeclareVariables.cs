using System;

class DeclareVariables
{
    static void Main()
    {
        /*Declare five variables choosing for each of them the most appropriate 
        of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent 
        the following values: 52130, -115, 4 825 932, 97, -10000.*/

        ushort numA = 52130;
        sbyte numB = -115;
        int numC = 4825932;
        byte numD = 97;
        short numE = -10000;

        Console.WriteLine(numA + "\n" + numB + "\n" + numC + "\n" + numD + "\n" + numE);
    }
}
