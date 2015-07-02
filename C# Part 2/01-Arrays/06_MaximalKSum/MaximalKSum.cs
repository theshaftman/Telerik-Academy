namespace _06_MaximalKSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MaximalKSum
    {
        /*	Write a program that reads two integer numbers N and K and 
        an array of N elements from the console.
        	Find in the array those K elements that have maximal sum.*/

        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            
            if (n >= k)
            {
                int[] nums = new int[n];
                Console.WriteLine("Enter {0} number(s) to array:", n);

                for (int i = 0; i < n; i++)
                {
                    nums[i] = int.Parse(Console.ReadLine());
                }

                List<int> bestSubsequence = new List<int>();
                bestSubsequence = FindSubsetWithMaxSum(nums, k);
                bestSubsequence.Reverse();

                Console.WriteLine("{0} element(s) from the array", bestSubsequence.Count);
                Console.WriteLine("Maximal Sum = {0}", bestSubsequence.Sum());
                Console.WriteLine("Subset with Maximal Sum: {0}", string.Join(", ", bestSubsequence));
            }
            else
            {
                Console.WriteLine("Error! N >= K!");
            }

            Console.WriteLine();
            Main();
        }

        private static List<int> FindSubsetWithMaxSum(int[] nums, int k)
        {
            List<int> subsetWithMaxSum = new List<int>();
            Array.Sort(nums);
            
            for (int i = nums.Length - 1; i >= 0 && k != 0; i--, k--)
            {
                subsetWithMaxSum.Add(nums[i]);
            }

            return subsetWithMaxSum;
        }
    }
}
