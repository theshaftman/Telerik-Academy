namespace _13_MergeSort
{
    using System;

    class MergeSort
    {
        /*	Write a program that sorts an array of integers using the
        Merge sort algorithm.*/

        static void Main(string[] args)
        {
            int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int length = numbers.Length;

            MergeSorting(numbers, 0, length - 1);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }

            Console.WriteLine();
        }

        static public void MergeSorting(int[] numbers, int left, int right)
        {
            int middle;

            if (right > left)
            {
                middle = (right + left) / 2;

                MergeSorting(numbers, left, middle);
                MergeSorting(numbers, (middle + 1), right);

                DoMerge(numbers, left, (middle + 1), right);
            }
        }

        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, leftEnd, elements, tmp;

            leftEnd = (mid - 1);
            tmp = left;
            elements = (right - left + 1);

            while ((left <= leftEnd) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                {
                    temp[tmp++] = numbers[left++];
                }
                else
                {
                    temp[tmp++] = numbers[mid++];
                }
            }

            while (left <= leftEnd)
            {
                temp[tmp++] = numbers[left++];
            }

            while (mid <= right)
            {
                temp[tmp++] = numbers[mid++];
            }

            for (i = 0; i < elements; i++)
            {
                numbers[right] = temp[right];

                right--;
            }
        }
    }
}
