namespace _02_RandomNumbers
{
    using System;

    class RandomNumbers
    {
        /*	Write a program that generates and prints to the console 10 random values in the range [100, 200].*/

        static void Main()
        {
            Random randomGenerator = new Random();
            int repeat = 10;
            int minValue = 100;
            int maxValue = 200;

            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(randomGenerator.Next(minValue, maxValue + 1));
            }
        }
    }
}
