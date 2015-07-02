using System;

class StringsAndObjects
{
    static void Main()
    {
        string strA = "Hello";
        string strB = "World";
        object obj = strA + " " + strB;
        string strObj = obj.ToString();

        Console.WriteLine(strObj);
    }
}
