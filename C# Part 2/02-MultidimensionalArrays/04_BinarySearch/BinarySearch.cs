namespace _04_BinarySearch
{
    using System;

    class BinarySearch
    {
        /*	Write a program, that reads from the console an array of N integers and an integer K, 
        sorts the array and using the method Array.BinSearch() finds the largest number in the array 
        which is ≤ K. */

        static void Main()
        {
            Console.Write("Write array (divided by space): ");
            string str = Console.ReadLine();
            Console.Write("Write K element to search: ");
            int k = int.Parse(Console.ReadLine());

            string[] strArr = str.Split(' ');
            int[] array = new int[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                array[i] = int.Parse(strArr[i]);
            }

            Array.Sort(array);
            int index = Array.BinarySearch(array, k);

            Console.WriteLine("{0} would be [{1}] in a sorted array", k, index);
        }
    }
}
