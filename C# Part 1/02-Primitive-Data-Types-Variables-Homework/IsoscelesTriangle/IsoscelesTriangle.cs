using System;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.UTF8Encoding.UTF8;
        char chr = '\u00A9';

        Console.WriteLine(@"
    {0}
   {0} {0}
  {0}   {0}
 {0} {0} {0} {0}", chr);
    }
}
