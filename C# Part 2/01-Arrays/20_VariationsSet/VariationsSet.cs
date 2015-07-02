namespace _20_VariationsSet
{
    using System;

    class VariationsSet
    {
        /*	Write a program that reads two numbers N and K and generates 
        all the variations of K elements from the set [1..N].*/

        static int n;
        static int k;

        static void Main()
        {
            try
            {
                Console.Write("N = ");
                n = int.Parse(Console.ReadLine());
                Console.Write("K = ");
                k = int.Parse(Console.ReadLine());

                char[] loops = new char[k];

                Console.WriteLine("Result:");
                NestedLoops(loops, 0);

                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Write a number!\n");
            }

            Main();
        }

        static void NestedLoops(char[] loops, int currentLoop)
        {
            if (currentLoop == k)
            {
                Console.WriteLine(string.Join(" ", loops));
            }
            else
            {
                for (int counter = 1; counter <= n; counter++)
                {
                    loops[currentLoop] = (char)(counter + 48);

                    NestedLoops(loops, (currentLoop + 1));
                }
            }
        }
    }
}
