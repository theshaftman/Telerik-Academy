namespace _09_FrequentNumber
{
    using System;

    class FrequentNumber
    {
        /*	Write a program that finds the most frequent number in an array.*/

        static void Main()
        {
            //int[] num = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            Console.Write("Enter array (devided by space): ");
            string str = Console.ReadLine();
            string[] numStr = str.Split(' ');
            int[] num = new int[numStr.Length];

            for (int i = 0; i < numStr.Length; i++)
            {
                num[i] = int.Parse(numStr[i]);
            }

            int max = 0;
            int maxNumber = 0;
            int maxTimes = 0;

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[j] == num[i])
                    {
                        max++;
                    }
                }                

                if (maxTimes < max)
                {
                    maxNumber = num[i];
                    maxTimes = max;
                }

                max = 0;
            }

            Console.WriteLine("Frequent number: {0} ({1} times)\n", maxNumber, maxTimes);

            Main();
        }
    }
}
