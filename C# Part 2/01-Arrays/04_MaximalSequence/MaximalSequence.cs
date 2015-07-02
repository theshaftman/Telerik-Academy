namespace _04_MaximalSequence
{
    using System;
    using System.Collections.Generic;

    class MaximalSequence
    {
        /*	Write a program that finds the maximal sequence of equal 
        elements in an array.*/

        static void Main()
        {
            //int[] num = { 2, 1, 1, 2, 3, 3, 2, 2, 1, 1 };

            Console.Write("Enter array (devided by space): ");
            string str = Console.ReadLine();
            string[] numStr = str.Split(' ');
            int[] num = new int[numStr.Length];

            for (int i = 0; i < numStr.Length; i++)
            {
                num[i] = int.Parse(numStr[i]);
            }

            int repeated = 1;
            List<int> numSequence = new List<int>();
            List<int> numSequenceIndex = new List<int>();

            numSequence.Add(num[0]);

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i - 1] == num[i])
                {
                    repeated++;
                }
                else
                {
                    numSequenceIndex.Add(repeated);
                    numSequence.Add(num[i]);
                    repeated = 1;
                }
            }

            numSequenceIndex.Add(repeated);
            int max = 0;
            int maxNumber = 0;

            for (int k = 0; k < numSequenceIndex.Count; k++)
            {
                if (numSequenceIndex[k] > max)
                {
                    max = numSequenceIndex[k];
                    maxNumber = numSequence[k];
                }
            }

            Console.Write("Maximal sequence: ");

            for (int index = 0; index < max; index++)
            {
                Console.Write("{0} ", maxNumber);
            }

            Console.WriteLine("\n");

            Main();
        }
    }
}
