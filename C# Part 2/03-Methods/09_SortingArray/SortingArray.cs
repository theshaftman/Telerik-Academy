namespace _09_SortingArray
{
    using System;

    class SortingArray
    {
        /*	Write a method that return the maximal element in a portion of array of integers 
        starting at given index.
        	Using it write another method that sorts an array in ascending / descending order.*/

        static int[] array;
        static int start;

        static void Main()
        {
            Console.Write("Write array(divided by space): ");
            string str = Console.ReadLine();
            Console.Write("Write start index: ");
            string startStr = Console.ReadLine();

            string[] arrayStr = str.Split(' ');
            array = new int[arrayStr.Length];
            int numbers;

            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse(arrayStr[i], out numbers))
                {
                    array[i] = int.Parse(arrayStr[i]);
                }
                else
                {
                    Console.WriteLine("Error! Write an INT!\n");

                    break;
                }
            }

            if (int.TryParse(startStr, out numbers))
            {
                start = int.Parse(startStr);

                if (Check())
                {
                    Console.WriteLine("Maximal element = {0}\nSorted array:", MaximalElement());
                    Console.WriteLine(string.Join(", ", AscendingSort()));
                    Console.WriteLine(string.Join(", ", DescendingSort()));
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error! Write an INT as a start index!\n");
            }

            Main();
        }

        private static bool Check()
        {
            return (start >= 0 && start <= array.Length - 1);
        }

        private static int MaximalElement()
        {
            int maximal = array[start];

            for (int i = start; i < array.Length; i++)
            {
                if (array[i] > maximal)
                {
                    maximal = array[i];
                }
            }

            return maximal;
        }

        private static int[] AscendingSort()
        {
            int[] ascending = new int[array.Length - start];

            for (int i = 0; i < ascending.Length; i++)
            {
                ascending[i] = array[i + start];
            }

            Array.Sort(ascending);

            return ascending;
        }

        private static int[] DescendingSort()
        {
            int[] ascending = new int[array.Length - start];

            for (int i = 0; i < ascending.Length; i++)
            {
                ascending[i] = array[i + start];
            }

            Array.Sort(ascending);
            Array.Reverse(ascending);

            return ascending;
        }
    }
}
