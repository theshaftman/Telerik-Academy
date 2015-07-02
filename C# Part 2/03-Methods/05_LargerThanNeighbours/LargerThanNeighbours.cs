namespace _05_LargerThanNeighbours
{
    using System;

    class LargerThanNeighbours
    {
        /*	Write a method that checks if the element at given position in given array of integers 
        is larger than its two neighbours (when such exist).*/

        static void Main()
        {
            Console.Write("Write array(divided by space): ");
            string str = Console.ReadLine();
            Console.Write("Write an INDEX of the number to search: ");
            string search = Console.ReadLine();

            string[] arrayStr = str.Split(' ');
            int[] array = new int[arrayStr.Length];
            int numbers;
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse(arrayStr[i], out numbers))
                {
                    array[i] = int.Parse(arrayStr[i]);
                }
                else
                {
                    Console.WriteLine("Error! Write INTS!\n");

                    Main();
                }
            }

            if (int.TryParse(search, out numbers))
            {
                index = int.Parse(search);
            }

            Console.WriteLine("Is {0} larger than it`s neighbours? {1}\n", array[index], CheckIfLarger(array, index));

            Main();
        }

        static bool CheckIfLarger(int[] array, int index)
        {
            bool isLarger = false;

            if (index > 0 && index < array.Length - 1)
            {
                if (array[index] > array[index + 1] && array[index] > array[index - 1])
                {
                    isLarger = true;
                }
            }
            else if (index == 0)
            {
                if (array[index] > array[index + 1])
                {
                    isLarger = true;
                }
            }
            else if (index == array.Length - 1)
            {
                if (array[index] > array[index - 1])
                {
                    isLarger = true;
                }
            }

            return isLarger;
        }
    }
}
