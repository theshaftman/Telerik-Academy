namespace _08_MaximalSum
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        /*	Write a program that finds the sequence of maximal sum 
        in given array.*/

        static void Main()
        {
            //int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            Console.Write("Enter array (devided by space): ");
            string str = Console.ReadLine();
            string[] numStr = str.Split(' ');
            int[] arr = new int[numStr.Length];

            for (int i = 0; i < numStr.Length; i++)
            {
                arr[i] = int.Parse(numStr[i]);
            }

            int maxTemp = int.MinValue;
            int maxEnd = 0;
            int start = 0;
            int startTemp = 0;
            int end = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                maxEnd += arr[i];

                if (arr[i] > maxEnd)
                {
                    maxEnd = arr[i];
                    startTemp = i;
                }
                if (maxEnd > maxTemp)
                {
                    maxTemp = maxEnd;
                    start = startTemp;
                    end = i;
                }
            }

            Console.WriteLine("Maximal sum is: {0}", maxTemp);

            for (int j = start; j <= end; j++)
            {
                Console.Write(arr[j] + " ");
            }

            Console.WriteLine("\n");
            Main();
        }
    }
}
