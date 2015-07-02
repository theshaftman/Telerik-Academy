namespace _07_SelectionSort
{
    using System;

    class SelectionSort
    {
        /*	Sorting an array means to arrange its elements in increasing 
        order. Write a program to sort an array.
        	Use the Selection sort algorithm: Find the smallest element, 
        move it at the first position, find the smallest from the rest, 
        move it at the second position, etc.*/

        static void Main()
        {
            //int[] arr = { 23, 2, 3, 34, 6 };

            Console.Write("Enter array (devided by space): ");
            string str = Console.ReadLine();
            string[] numStr = str.Split(' ');
            int[] arr = new int[numStr.Length];

            for (int i = 0; i < numStr.Length; i++)
            {
                arr[i] = int.Parse(numStr[i]);
            }
            
            SelectSort(arr, arr.Length);
            
            for (int j = 0; j < 5; j++)
            {
                Console.Write(arr[j] + " "); //after sorting
            }

            Console.WriteLine();
        }

        ///selection sort
        static void SelectSort(int[] dataset, int n)
        {
            int i, j;

            for (i = 0; i < n; i++)
            {
                int min = i;

                for (j = i + 1; j < n; j++)
                {
                    if (dataset[j] < dataset[min]) 
                    {
                        min = j;
                    }
                }

                int temp = dataset[i];
                dataset[i] = dataset[min];
                dataset[min] = temp;
            }
        }
    }
}
