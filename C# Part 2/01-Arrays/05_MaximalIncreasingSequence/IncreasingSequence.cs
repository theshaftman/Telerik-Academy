namespace _05_MaximalIncreasingSequence
{
    using System;
    using System.Collections.Generic;

    class IncreasingSequence
    {
        /*	Write a program that finds the maximal increasing sequence 
        in an array.*/

        static void Main()
        {
            //int[] num = { 3, 2, 4, 6, 7, 1, 2, 3, 4};

            Console.Write("Enter array (devided by space): ");
            string str = Console.ReadLine();
            string[] numStr = str.Split(' ');
            int[] num = new int[numStr.Length];

            for (int i = 0; i < numStr.Length; i++)
            {
                num[i] = int.Parse(numStr[i]);
            }
            
            int repeated = 1;
            List<int> numIndex = new List<int>();
            List<int> numLength = new List<int>();
            int max = 0;

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i - 1] < num[i])
                {
                    repeated++;
                }
                else
                {
                    numIndex.Add(i - 1);
                    repeated = 1;
                }
            }

            numIndex.Add(num.Length - 1);

            int length = 0;
            int index = 0;

            for (int j = 0; j < numIndex.Count; j++)
            {
                if (j == 0)
                {
                    length = numIndex[j];
                    numLength.Add(length);
                }
                else
                {
                    length = numIndex[j] - numIndex[j - 1];
                    numLength.Add(length);

                    if (length > max)
                    {
                        max = length;
                        index = j;
                    }
                }
            }

            int[] endResult = new int[max];
            int maxIndex = numIndex[index];

            for (int l = 0; l < max; l++)
            {
                endResult[l] = num[maxIndex];
                maxIndex--;
            }

            Array.Reverse(endResult);

            Console.Write("Increasing sequence: ");
            foreach (var item in endResult)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("\n");
            Main();
        }
    }
}
