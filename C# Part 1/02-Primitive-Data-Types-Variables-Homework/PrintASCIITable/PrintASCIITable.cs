using System;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.UTF8Encoding.UTF8;

        for (int i = 0; i <= 255; i++)
        {
            char symbol = (char)i;
            Console.WriteLine("{0}: {1}", i, symbol);
        }
    }
}

