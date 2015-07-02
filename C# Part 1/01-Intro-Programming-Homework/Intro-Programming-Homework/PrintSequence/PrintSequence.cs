using System;

class PrintSequence
{
    static void Main()
    {
        int i = 0;

        while (i < 10)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine("-" + (i + 2));
            }
            else
            {
                Console.WriteLine(i + 2);
            }

            i++;
        }
    }
}
