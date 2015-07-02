namespace _11_BinarySearch
{
    using System;
    using System.Collections.Generic;

    class BinarySearch
    {
        /*	Write a program that finds the index of given element 
        in a sorted array of integers by using the Binary search 
        algorithm.*/

        static void Main()
        {
            int[] arr = { 1, 2, 15, 3, 4, 5, 7, 9 };
            int search = 9;
            Array.Sort(arr);

            List<int> result = new List<int>(arr);
            int length = result.Count;
            int left = 0;
            int right = result.Count;
            
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (result[length / 2] > search)
                {
                    result.RemoveRange((length / 2), (length / 2));
                    result.RemoveAt(result.Count - 1);
                    right = ((right - left) / 2) - 1;

                    if (right == 0)
                    {
                        right = left;
                    }
                }
                else if (result[length / 2] < search)
                {
                    result.RemoveRange(0, (length  / 2));
                    result.RemoveRange(0, 1);
                    left += ((right - left) / 2) + 1;
                }
                else
                {
                    int res = ((right - left) / 2) + left;
                    Console.WriteLine("Result! Index [{0}] equals {1}", res, result[length / 2]);
                    
                    break;
                }

                length = result.Count;
            }
        }
    }
}
