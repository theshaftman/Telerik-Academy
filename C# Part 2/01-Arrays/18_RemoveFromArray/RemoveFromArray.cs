namespace _18_RemoveFromArray
{
    using System;
    using System.Collections.Generic;

    class RemoveFromArray
    {
        /*	Write a program that reads an array of integers and removes 
        from it a minimal number of elements in such a way that the 
        remaining array is sorted in increasing order.
        	Print the remaining sorted array.*/

        static void Main()
        {
            int[] numbers = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            Array.Reverse(numbers);
            List<int> result = new List<int>();
            
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] <= max && numbers[i] != 0)
                {
                    max = numbers[i];
                    result.Add(numbers[i]);
                }
            }

            result.Reverse();

            Console.Write("Increasing array result: ");

            for (int j = 0; j < result.Count; j++)
            {
                Console.Write("{0} ", result[j]);
            }

            Console.WriteLine();
        }
    }
}
