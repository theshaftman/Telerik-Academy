namespace _16_SubsetWithSumS
{
    using System;
    using System.Collections.Generic;

    class SubsetWithSumS
    {
        /*	We are given an array of integers and a number S.
        	Write a program to find if there exists a subset of the elements 
        of the array that has a sum S.*/

        static void Main()
        {
            int[] nums = { 2, 1, 2, 4, 3, 5, 2, 6 };
            int sum = 4;

            if (nums.Length > 0)
            {
                bool isThere = false;
                List<int> bestSubsequence = new List<int>(nums);
                Array.Sort(nums);

                for (int i = 0; i < bestSubsequence.Count; i++)
                {
                    int sumRes = 0;

                    for (int j = i; j < bestSubsequence.Count; j++)
                    {
                        sumRes = bestSubsequence[j] + bestSubsequence[i];

                        if (sumRes == sum)
                        {
                            isThere = true;

                            break;
                        }
                        else if (sumRes > sum)
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine("Array: {0}", string.Join(", ", bestSubsequence));
                Console.WriteLine("Is there a sum {0}? {1}", sum, isThere);
            }
            else
            {
                Console.WriteLine("Error! N >= K!");
            }
        }
    }
}
