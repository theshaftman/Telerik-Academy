namespace _01_Assertions
{
    using System;
    using System.Diagnostics;

    public class AssertionsHomework
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            Debug.Assert(arr.Length > 0, "Array length can not be empty.");
            Debug.WriteLineIf(arr.Length == 0, "Array length is empty.");
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            int minElementIndex = startIndex;

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            Debug.Assert(arr != null, "Array can not equal null.");
            Debug.Assert(
                endIndex >= startIndex,
                "The end index must be higher than the start index.");

            Debug.WriteLineIf(arr == null, "Array equals null.");
            Debug.WriteLineIf(
                startIndex < endIndex,
                "The end index is lower than the start index.");

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;

            Debug.Assert(x != null && y != null, "X and Y can not be null.");
            Debug.WriteLineIf(x == null || y == null, "X or Y equals null.");
        }

        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array can not equal null.");
            Debug.WriteLineIf(arr == null, "Array equals null.");

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;

                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            Debug.Assert(arr != null, "Array can not equal null.");
            Debug.Assert(value != null, "Value can not equal null.");

            Debug.WriteLineIf(arr == null, "Array equals null.");
            Debug.WriteLineIf(value == null, "Value equals null.");

            // Searched value not found
            return -1;
        }

        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            // Test sorting empty array
            // SelectionSort(new int[0]);

            // Test sorting single element array
            SelectionSort(new int[1]);

            Console.WriteLine(BinarySearch(arr, -1000));
            Console.WriteLine(BinarySearch(arr, 0));
            Console.WriteLine(BinarySearch(arr, 17));
            Console.WriteLine(BinarySearch(arr, 10));
            Console.WriteLine(BinarySearch(arr, 1000));
        }
    }
}